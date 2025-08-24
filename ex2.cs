using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EX01();
            EX02();
            Ex03();
            Ex04();
            Ex05();
            Ex06();
            Ex07();
            Ex08();
        }
        static void EX01()
        {
            Console.WriteLine("Nhap nhiet do: ");
            string C = Console.ReadLine();
            double number = 0;
            while (!double.TryParse(C, out number))
                Console.WriteLine("Xin vui long nhap so.");
            C = Console.ReadLine();
            double K = number + 273;
            double F = number * 18 / 10 + 32;
            Console.WriteLine($"Kelvin = {K} ");
            Console.WriteLine($"Fahrenhit = {F} ");
        }
        static void EX02()
        {
            Console.WriteLine("Enter radius: ");
            string R = Console.ReadLine();
            double radius = 0;
            while (!double.TryParse(R, out radius))
            {
                Console.WriteLine("Xin vui long nhap so.");
                R = Console.ReadLine();
            }
            double surface = 4 * Math.PI * Math.Pow(radius, 2);
            double volume = 4 / 3 * Math.PI * Math.Pow(radius, 3);
            Console.WriteLine($"Sphere with radius = {radius}:\n" +
                $"\tsurface = {surface}\n" +
                $"\tvolume = {volume}");
        }
        static void Ex03()
        {
            Console.WriteLine("Enter a: ");
            Console.WriteLine("Enter b: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"{a} + {b} = {a + b}");
            Console.WriteLine($"{a} - {b} = {a - b}");
            Console.WriteLine($"{a} * {b} = {a * b}");
            Console.WriteLine($"{a} / {b} = {a / b}");
            Console.WriteLine($"{a} % {b} = {a % b}");

        }
        static void Ex04()
        {
            Console.Write("Number 1: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Number 2: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write(" (+,-,*,/,%) : ");
            char op = char.Parse(Console.ReadLine());

            int result = 0;

            switch (op)
            {
                case '+': result = a + b; break;
                case '-': result = a - b; break;
                case '*': result = a * b; break;
                case '/': result = a / b; break;
                case '%': result = a % b; break;
                default: Console.WriteLine("Not valid"); return;

            }
            Console.WriteLine("Answer: " + result);
        } static void Ex05()
        {
            for (int y = -5; y <= 5; y++)
            {
                int x = y * y + 2 * y + 1;
                Console.WriteLine($"y = {y}, x = {x}");
            }
        } static void Ex06()
        {
            Console.Write("Do dai duong di (km): ");
            double khoangcach = double.Parse(Console.ReadLine());

            Console.Write("So gio: ");
            double hours = double.Parse(Console.ReadLine());
            Console.Write("So phut: ");
            double minutes = double.Parse(Console.ReadLine());
            Console.Write("So giay: ");
            double seconds = double.Parse(Console.ReadLine());

            double timeHours = hours + minutes / 60.0 + seconds / 3600.0;

            double speedKm = khoangcach / timeHours;
            double speedMiles = speedKm / 1.609;

            Console.WriteLine("Toc do km/h la: " + speedKm.ToString("F2"));
            Console.WriteLine("Toc do miles/h la: " + speedMiles.ToString("F2"));
        } static void Ex07()
        {
            Console.WriteLine("Enter radius: ");
            string R = Console.ReadLine();
            double radius = 0;
            while (!double.TryParse(R, out radius))
            {
                Console.WriteLine("Xin vui long nhap so.");
                R = Console.ReadLine();
            }
            double surface = 4 * Math.PI * Math.Pow(radius, 2);
            double volume = 4 / 3 * Math.PI * Math.Pow(radius, 3);
            Console.WriteLine($"Sphere with radius = {radius}:\n" +
                $"\tsurface = {surface}\n" +
                $"\tvolume = {volume}");
        } static void Ex08() 
        {
            Console.Write("Nhap ki tu: ");
            char c = char.Parse(Console.ReadLine().ToLower());

            if ("aeiou".Contains(c))
                Console.WriteLine("Đay la nguyen am.");
            else if (char.IsDigit(c))
                Console.WriteLine("Đay la chu so.");
            else
                Console.WriteLine("Ky hieu khac");
        }

    }
    }
