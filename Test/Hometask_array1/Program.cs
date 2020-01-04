using System;

namespace TRASH
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                    Массив, с выводом в обратном порядке
             */

            while (true)
            {
                Console.Clear();

                try
                {
                    Console.WriteLine("Введите длину массива:");
                    int ArrayLenght = int.Parse(Console.ReadLine());
                    int[] Array = new int[ArrayLenght];

                    Console.WriteLine("Вводите числа и они добавятся в массив:");
                    for (uint i = 0; i < Array.Length; i++)
                    {
                        Array[i] = int.Parse(Console.ReadLine());
                    }

                    Console.WriteLine();

                    for (int i = ArrayLenght - 1; i >= 0; i--)
                    {
                        Console.Write($"[{Array[i]}] ");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("\nОшибка ввода!");
                    Console.ReadLine();
                    continue;
                }

                Console.ReadLine();
            }
        }
    }
}