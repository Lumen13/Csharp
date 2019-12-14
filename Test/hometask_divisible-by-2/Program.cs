using System;

namespace hometask_divisible_by_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double NumInput;

            Console.WriteLine("Программа проверки чётности числа" +
                "\n\nВведите число");
            NumInput = Convert.ToDouble(Console.ReadLine());

            if (NumInput % 2 == 0)
            {
                Console.WriteLine("Число чётное");
            }
            else
            {
                Console.WriteLine("Число нечётное");
            }
        }
    }
}
