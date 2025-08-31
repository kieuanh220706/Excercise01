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
            int wincount = 0;
            int losecount = 0;
            string choice;
            do
            {
                Random rnd = new Random();
                int die_1 = rnd.Next(1, 7);
                int die_2 = rnd.Next(1, 7);
                int sum = die_1 + die_2;

                while (true)
                {
                    Console.WriteLine("Ban doan tai, xiu hay 5?");
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

                }
                else if (choice == "tai" && sum <= 5)
                {
                    Console.WriteLine("Ban da doan sai, ban bi tru 5$");
                    money -= 5;
                    losecount++;
                }
                else if (choice == "xiu" && sum < 5)
                {
                    Console.WriteLine("Ban da thang, ban duoc cong 5$");
                    money += 5;
                    wincount++;
                }
                else if (choice == "xiu" && sum >= 5)
                {
                    Console.WriteLine("Ban da doan sai, ban bi tru 5$");
                    money -= 5;
                    losecount++;
                }
                else if (choice == "5" && sum == 5)
                {
                    Console.WriteLine("Ban da trung giai dac biet, ban duoc cong 15$");
                    money += 15;
                    wincount++;

                }
                else if (choice == "5" && sum != 5)

                {
                    Console.WriteLine("Ban da doan sai, ban bi tru 5$");
                    money -= 5;
                    losecount++;
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
                        Console.WriteLine("Hen gap lai ban lan sau");
                        Console.WriteLine($"So van thang {wincount}, so van thua: {losecount}, so tien con lai la {money}"); return;
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

