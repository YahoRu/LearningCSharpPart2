using System;

namespace Lesson2Part3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите трехзначное число: ");

            int number = int.Parse(Console.ReadLine());

            int firstNumber = number / 100;

            int secondNumber = (number % 100) / 10;

            int thirdNumber = number % 10;

            bool answer = secondNumber <= firstNumber && secondNumber > thirdNumber;

            Console.WriteLine(answer);
        }
    }
}
