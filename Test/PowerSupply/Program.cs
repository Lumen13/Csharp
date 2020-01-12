using System;

namespace RUBBISH2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("Автосалон 'Grand-Auto'");
                Console.WriteLine("\n1. Добавить автомобиль");
                Console.WriteLine("2. Посмотреть какие машины в наличии");
                Console.WriteLine("3. Продать автомобиль");
                Console.WriteLine("4. Бюджет");
                                
                string[] NewCar = new string[4];
                string[] CarsInfo = new string[4]
                {
                    "\nБренд (марка) автомобиля:",
                    "Модель:",
                    "Цвет:",
                    "Цена:"
                };
                for (int n = 0; n < NewCar.Length; n++)
                {
                    Console.WriteLine(CarsInfo[n]);
                    NewCar[n] = Convert.ToString(Console.ReadLine());              
                }

                Console.ReadLine();
            }
        }
    }
}