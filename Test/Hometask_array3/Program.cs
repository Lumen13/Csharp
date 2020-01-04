using System;

namespace Hometask_array3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                   Поиск наименьшего числа в массиве
            */

            while (true)
            {
                Console.Clear();

                int Comparing = 0;
                int LowerNum = 0;
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

                    LowerNum = Array[0];
                    for (int i = 0; i < Array.Length; i++)
                    {
                        Comparing = Array[i];                        
                        if (LowerNum > Comparing)
                            LowerNum = Comparing;                        
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("\nОшибка ввода!");
                    Console.ReadLine();
                    continue;
                }

                Console.WriteLine(LowerNum);
                Console.ReadLine();
            }
        }
    }
}
