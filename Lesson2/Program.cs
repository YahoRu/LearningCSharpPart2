using System;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int number = 124;

            int temp = number;

            Console.WriteLine((temp % 10) + ((temp % 100) / 10) + (temp  / 100));
        }
    }
}
