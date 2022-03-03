using System;

namespace Lesson2Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            Console.WriteLine("Введите координату x1, нажмите Enter и введите переменную y1:");

            double x1 = int.Parse(Console.ReadLine());
            double y1 = int.Parse(Console.ReadLine());

            double radius = Math.Sqrt(Math.Pow(rnd.Next(0, 10), 2)) + (Math.Pow(rnd.Next(0, 10), 2));
            
            bool result = (radius >= x1 && radius >= y1);

            Console.WriteLine(result);

        }
    }
}
