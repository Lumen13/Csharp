using System;

namespace Hometask_triangles
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                uint Hight;
                try
                {
                    Console.WriteLine("Введите высоту треугольника");
                    Hight = uint.Parse(Console.ReadLine());
                    if (Hight >= 30)
                    {
                        Console.WriteLine("\nОшибка! Введите небольшое положительное целое число");
                        Console.ReadLine();
                        continue;
                    }
                    else if (Hight == 0)
                    {
                        Console.WriteLine("\nОшибка! Высота не может быть нулевой");
                        Console.ReadLine();
                        continue;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("\nОшибка! Введите небольшое положительное целое число");
                    Console.ReadLine();
                    continue;
                }

                for (uint i = 0; i < Hight; i++)            // #
                {                                           // ##
                    Console.WriteLine("");                  // ###
                    for (uint a = 0; a <= i; a++)           // ####
                    {                                       // #####
                        Console.Write("#");
                    }
                }

                Console.WriteLine("");

                for (uint i = 0; i < Hight; i++)            // #####
                {                                           // ####
                    Console.WriteLine("");                  // ###
                    for (uint a = Hight; i < a; a--)        // ##
                    {                                       // #
                        Console.Write("#");
                    }
                }

                Console.WriteLine("");

                for (uint i = 0; i < Hight; i++)            //     #
                {                                           //    ##
                    Console.WriteLine("");                  //   ###
                    for (uint a = Hight; i < a; a--)        //  ####
                    {                                       // #####
                        Console.Write(" ");
                    }
                    for (uint a = 0; a <= i; a++)           
                    {                                       
                        Console.Write("#");
                    }
                }

                Console.WriteLine("");

                for (uint i = 0; i < Hight; i++)            // #####
                {                                           //  ####
                    Console.WriteLine("");                  //   ###
                    for (uint a = 0; a <= i; a++)           //    ##
                    {                                       //     #
                        Console.Write(" ");
                    }
                    for (uint a = Hight; i < a; a--)
                    {
                        Console.Write("#");
                    }
                }

                Console.ReadLine();
            }
        }
    }
}
