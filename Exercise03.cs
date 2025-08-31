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
                        Console.WriteLine("Lua chon khong hop le. Chi nhap: tai hoac xiu");
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
                        Console.WriteLine("Hen gap lai ban lan sau");
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
             

        }

                   

             
            
        }     
}


