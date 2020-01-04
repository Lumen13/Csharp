﻿using System;

namespace TRASH
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                    Массив, заполняемый с клавиатуры
             */

            while (true)
            {
                Console.Clear();

                try
                {
                    Console.WriteLine("Введите длину массива:");
                    uint ArrayLenght = uint.Parse(Console.ReadLine());
                    int[] Array = new int[ArrayLenght];

                    Console.WriteLine("Вводите числа и они добавятся в массив:");
                    for (uint i = 0; i < Array.Length; i++)
                    {
                        Array[i] = int.Parse(Console.ReadLine());
                    }

                    Console.WriteLine();

                    for (uint i = 0; i < Array.Length; i++)
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