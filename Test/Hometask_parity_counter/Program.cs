using System;

namespace Hometask_parity_counter
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                int FirstValue, SecondValue, CheckParity, CheckRecursion, SumParity = 0, SumOddness = 0;
                uint CounterParity = 0, CounterOddness = 0;
                Console.WriteLine("Введите 2 целых числа, чтобы задать диапазон проверки четности и посчитать сумму\n");

                try
                {
                    Console.WriteLine("Проверяем от числа...");
                    FirstValue = int.Parse(Console.ReadLine());
                    Console.WriteLine("и до числа...");
                    SecondValue = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                }
                catch (Exception)
                {
                    Console.WriteLine("\nВведённое значение не является целым числом или оно слишком длинное");
                    Console.ReadLine();
                    continue;
                }

                if (FirstValue >= SecondValue)
                    Console.WriteLine("Неверный диапазон! Первое число должно быть меньше второго");

                CheckRecursion = SecondValue - FirstValue;
                if (CheckRecursion >= 1001)
                {
                    Console.WriteLine("Вы ввели слишком большой диапазон чисел!\n" +
                        "Попробуйте ввести 2 приближенных друг к другу по значениям числа");
                    Console.ReadLine();
                    continue;
                }

                while (FirstValue <= SecondValue)
                {
                    CheckParity = FirstValue % 2;
                    if (CheckParity == 0)
                    {
                        Console.WriteLine($"{FirstValue} - четное");
                        SumParity += FirstValue;
                        CounterParity++;
                        FirstValue++;
                    }
                    else
                    {
                        Console.WriteLine($"{FirstValue} - не четное");
                        SumOddness += FirstValue;
                        CounterOddness++;
                        FirstValue++;
                    }
                }

                Console.WriteLine($"\nКоличество чётных чисел = {CounterParity}" +
                    $"\nКоличество нечётных чисел = {CounterOddness}" +
                    $"\nОбщая сумма чётных чисел = {SumParity}" +
                    $"\nОбщая сумма нечётных чисел = {SumOddness}");

                Console.ReadLine();
            }            
        }
    }
}
