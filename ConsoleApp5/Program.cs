using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1

            Console.Write("a =  ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            double c = double.Parse(Console.ReadLine());
            double d = Math.Pow(b, 2) - 4 * a * c;
            if (d>0)
            {
                double x1 = (-b + Math.Sqrt(d)) / 2 * a;
                double x2 = (-b - Math.Sqrt(d)) / 2 * a;
                Console.Write($"Дискриминант имеет два корня\nx1 = {x1:f2}\nx2= {x2:f2}");
            }
            else if (d==0)
            {
                double x0 = -b / 2 * a;
                Console.Write($"Дискриминант имеет один корень\nx1 = {x0:f2}");
            }
            else
            {
                Console.Write("Нет корней");
            }
            Console.Read();

            //Задание 2

            Console.Write("Введите первую сторону - ");
            double side1 = double.Parse(Console.ReadLine());
            Console.Write("Введите вторую сторону - ");
            double side2 = double.Parse(Console.ReadLine());
            Console.Write("Введите третью сторону - ");
            double side3 = double.Parse(Console.ReadLine());
            double p = (side1 + side2 + side3) / 2;
            if (side3 < side1 + side2 && side1 < side2 + side3 && side2 < side1 + side3)
            {
                Console.WriteLine("Треугольник существует");
                Console.WriteLine($"Площадь треугольника равна = {Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3)):f2}");
            }
            else { Console.WriteLine("Треугольник не существует"); }
            Console.Read();
        }
    }
}
