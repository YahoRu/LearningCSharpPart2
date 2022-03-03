using System;

namespace Lesson2Part4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое трехзначное число: ");

            string incomingNumber = Console.ReadLine();

            char[] charArr = incomingNumber.ToCharArray();

            Array.Reverse(charArr);

            string s = new string(charArr);

            int result = int.Parse(s);

            Console.WriteLine(result);

        }
    }
}
