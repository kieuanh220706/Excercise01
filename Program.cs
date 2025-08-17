using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EX01();
            EX02();
            EX03();
            EX04();
            EX05();
            EX06();
            EX07();
            EX08();
            EX09();
            EX10();
        }


        static void EX01()
        {
            Console.WriteLine("Number1:");
            int Num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Number2:");
            int Num2 = Convert.ToInt32(Console.ReadLine());
            int sum = Num1 + Num2;
            Console.WriteLine($"Answer: {sum}");
            Console.ReadKey();

        }
        static void EX02()
        {
            Console.Write("a= ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b= ");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = b;
            Console.WriteLine($"b ={a}, a={c}");
            Console.ReadKey();
        }
        static void EX03()
        {
            Console.Write("a= ");
            Decimal a = Convert.ToDecimal(Console.ReadLine());
            Console.Write("b= ");
            Decimal b = Convert.ToDecimal(Console.ReadLine());
            Decimal c = a * b;
            Console.WriteLine($"Dap an la: {c}");
            Console.ReadKey();
        }
        static void EX04()
        {
            Console.Write("Nhap so feet:");
            double feet = Convert.ToDouble(Console.ReadLine());
            double metes = feet * 0.3048;
            Console.WriteLine($"Dap an la sau khi doi la: {metes}");
            Console.ReadKey();
        } static void EX05()
        {
            Console.Write("Do C: ");
            double c = double.Parse(Console.ReadLine());
            double f = (c * 9 / 5) + 32;
            Console.WriteLine($"{c} °C = {f} °F");
            Console.Write(" Do F: ");
            f = double.Parse(Console.ReadLine());
            c = (f - 32) * 5 / 9;
            Console.WriteLine($"{f} Do F = {c} Do C");
            Console.ReadKey();
        } static void EX06()
        {
            Console.WriteLine("Size of int: " + sizeof(int));
            Console.WriteLine("Size of float: " + sizeof(float));
            Console.WriteLine("Size of double: " + sizeof(double));
            Console.WriteLine("Size of char: " + sizeof(char));
            Console.WriteLine("Size of bool: " + sizeof(bool));
            Console.WriteLine("Size of byte: " + sizeof(byte));
            Console.WriteLine("Size of short: " + sizeof(short));
            Console.WriteLine("Size of long: " + sizeof(long));
            Console.ReadKey();
        } static void EX07()
        {
            Console.Write("Nhap ky tu: ");
            char ch = Console.ReadKey().KeyChar;
            Console.WriteLine();
            int ascii = (int)ch;
            Console.WriteLine($"Ky tu: {ch}, ASCII: {ascii}");
            Console.ReadKey();
        } static void EX08()
        {
            Console.Write("Ban kinh hinh tron: ");
            double r = double.Parse(Console.ReadLine());
            double S = Math.PI * r * r;
            Console.WriteLine($"Dien tich hinh tron = {S}");
            Console.ReadKey();
        } static void EX09()
        {
            Console.Write("Canh hinh vuong la: ");
            double a = double.Parse(Console.ReadLine());
            double S = a * a;
            Console.WriteLine($"Dien tich hinh vuong = {S}");
            Console.ReadKey();
        } static void EX10()
        {
            int day, nam, tuan, ngay, DayOfWeek = 7;
            Console.WriteLine("So ngay la:");
            day = Convert.ToInt32(Console.ReadLine());
            nam = day / 365;
            tuan = (day % 365) / DayOfWeek;
            ngay = (day % 365) / DayOfWeek;
            Console.WriteLine("So ngay = {1} nam, {2} tuan va {3} ngay", day, nam, tuan, ngay);
            Console.ReadKey();

        }
            

        

    





    }
    
}
