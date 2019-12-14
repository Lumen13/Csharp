using System;

namespace Hometask_ariphmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            double FirstValue, SecondValue, ThirdValue;

            Console.WriteLine("Программа по вычеслению суммы и произведения трёх чисел" +
                "\nВведите первое число");
            FirstValue = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите второе число");
            SecondValue = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите третье число");
            ThirdValue = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Сумма трёх чисел = {FirstValue + SecondValue + ThirdValue}");
            Console.WriteLine($"Произведение трёх чисел = {FirstValue * SecondValue * ThirdValue}");
        }
    }
}
