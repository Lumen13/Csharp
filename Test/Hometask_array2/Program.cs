using System;

namespace Hometask_array2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                   Вывод суммы чётных чисел в массиве
            */

            while (true)
            {
                Console.Clear();
                
                int Sum = 0;
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
                    
                    for (int i = 0; i < Array.Length; i++)
                    {
                        if (Array[i] % 2 == 0)                        
                            Sum += Array[i];                        
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("\nОшибка ввода!");
                    Console.ReadLine();
                    continue;
                }

                Console.WriteLine(Sum);
                Console.ReadLine();
            }
        }
    }
}
