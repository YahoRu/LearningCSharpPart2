using System;

namespace Lesson2Part5
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = 1522222221.0;

            long temp = (long)number;

            bool answer = temp == number;   

            Console.WriteLine(answer);
        }
    }
}
