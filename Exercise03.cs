using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Exercise03
{
    internal class Program
    {
        static void Main(string[] args)
        { ex02();
            ex01(); 
        }
        static void ex02()
        {
            Console.WriteLine("Chao mung ban den voi tro choi tai xiu");
            double money = 100;
            Console.WriteLine("So tien ban dang co la: {0}", money);
            int wincount = 0;
            int losecount = 0;
            string choice;
            do
            {
                Random rnd = new Random();
                int dice1 = rnd.Next(1, 7);
                int dice2 = rnd.Next(1, 7);
                int sum = dice1 + dice2;

                while (true)
                {
                    Console.WriteLine("Ban doan tai hay xiu?");
                    choice = Console.ReadLine().Trim().ToLower();
                    if (choice == "tai" || choice == "xiu" || choice == "5")
                    { break; }
                    else
                    {
                        Console.WriteLine("Lua chon khong hop le. Chi nhap: tai/ xiu/ 5");
                    }


                }

                if (choice == "tai" && sum > 5)
                {
                    Console.WriteLine("Ban da thang, ban duoc cong 5$");
                    money += 5;
                    wincount++;
                    Console.WriteLine("So tien ban dang co la: {0}", money);
                }
                else if (choice == "tai" && sum <= 5)
                {
                    Console.WriteLine("Ban da doan sai, ban bi tru 5$");
                    money -= 5;
                    losecount++;
                    Console.WriteLine("So tien ban dang co la: {0}", money);
                }
                else if (choice == "xiu" && sum < 5)
                {
                    Console.WriteLine("Ban da thang, ban duoc cong 5$");
                    money += 5;
                    wincount++;
                    Console.WriteLine("So tien ban dang co la: {0}", money);
                }
                else if (choice == "xiu" && sum >= 5)
                {
                    Console.WriteLine("Ban da doan sai, ban bi tru 5$");
                    money -= 5;
                    losecount++;
                    Console.WriteLine("So tien ban dang co la: {0}", money);
                }
                else if (choice == "5" && sum == 5)
                {
                    Console.WriteLine("Ban da trung giai dac biet, ban duoc cong 15$");
                    money += 15;
                    wincount++;
                    Console.WriteLine("So tien ban dang co la: {0}", money);

                }
                else if (choice == "5" && sum != 5)

                {
                    Console.WriteLine("Ban da doan sai, ban bi tru 5$");
                    money -= 5;
                    losecount++;
                    Console.WriteLine("So tien ban dang co la: {0}", money);
                }
                else
                {
                    Console.WriteLine("Lua chon khong hop le");
                }

                while (true)
                {
                    Console.WriteLine("\nBan co muon choi tiep khong? <Co/Khong>");
                    string tl = Console.ReadLine();
                    if (tl == "Khong")
                    {
                        Console.WriteLine($"So van thang {wincount}, so van thua: {losecount}, so tien con lai la {money}");
                        Console.WriteLine("Hen gap lai ban lan sau!");
                        return;
                    }
                    else if (tl == "Co")
                    {
                        Console.WriteLine("Moi ban tiep tuc choi"); break;
                    }
                    else
                    {
                        Console.WriteLine("Lua chon khong hop le, moi ban chon lai");
                    }

                }

            } while (true);
        } static void ex01()
        {
            int money = 100;   
            int wincount = 0;  
            int losecount = 0; 

            Console.WriteLine("\n=== Chao mung den voi tro choi doan so ===\n");

            bool continuePlaying = true;

            while (continuePlaying && money > 0)
            {
                
                int level;
                Console.WriteLine("\nLevel:\n\t1.Kho: 4 lan choi\n\t2.Trung binh: 7 lan choi\n\t3.De: 10 lan choi");
                Console.Write("Ban chon cap do nao? [1/2/3]: ");
                while (!(int.TryParse(Console.ReadLine(), out level) && level >= 1 && level <= 3))
                {
                    Console.WriteLine("Vui long nhap so hop le (1, 2 hoac 3).");
                }

                int solanchoi = (level == 1) ? 4 : (level == 2 ? 7 : 10);
                int prizeWin = (level == 1) ? 10 : (level == 2 ? 7 : 4);
                int prizeLose = prizeWin;

                Random rnd = new Random();
                int comp_num = rnd.Next(0, 100) + 1;

                bool is_won = false;

                for (int i = 0; i < solanchoi; i++)
                {
                    int man_num;
                    Console.Write($"{i + 1}.Ban doan so [1-100]: ");
                    while (!int.TryParse(Console.ReadLine(), out man_num) && man_num >= 1 && man_num <= 100)
                    {
                        Console.WriteLine("Vui long nhap so nguyen tu 1 den 100.");
                    }

                    if (man_num == comp_num)
                    {
                        is_won = true;
                        Console.WriteLine("Chuc mung! Ban doan dung so cua may!");
                        break;
                    }
                    else if (man_num > comp_num)
                    {
                        Console.WriteLine("So ban doan lon hon so may cho.");
                    }
                    else
                    {
                        Console.WriteLine("So ban doan nho hon so may cho.");
                    }
                }

                if (is_won)
                {
                    money += prizeWin;
                    wincount++;
                }
                else
                {
                    Console.WriteLine($"May cho ra so {comp_num}. Ban da thua!");
                    money -= prizeLose;
                    losecount++;
                }

                Console.WriteLine($"So tien hien co: {money}$");

                if (money <= 0)
                {
                    Console.WriteLine("Ban da het tien, tro choi ket thuc!");
                    break;
                }

                Console.Write("Ban co muon choi tiep khong? <Co/Khong>: ");
                string tl = Console.ReadLine();
                if (tl == "Khong")
                {
                    Console.WriteLine($"So van thang {wincount}, so van thua: {losecount}, so tien con lai la {money}");
                    Console.WriteLine("Hen gap lai ban lan sau!");
                    return;
                }
                else if (tl == "Co")
                {
                    Console.WriteLine("Moi ban tiep tuc choi"); break;
                }
                else
                {
                    Console.WriteLine("Lua chon khong hop le, moi ban chon lai");
                }
            } while (true) ;

           
        }
    }
            
             

     }



