using System;

namespace RUBBISH2
{
    class Program
    {
        static void CarAdd()
        {
            Cars cars = new Cars();            
            for (int n = 0; n < cars.CarNewArray.Length; n++)
            {
                Console.WriteLine(cars.CarInfoArray[n]);
                cars.CarNewArray[n] = Convert.ToString(Console.ReadLine());
            }
        }

        static void CarInfo()
        {

        }

        static void CarSell()
        {

        }

        static void Cash()
        {

        }

        public class Cars
        {
            public string[] CarNewArray = new string[4];
            public string[] CarInfoArray = new string[4]
            {
                    "\nБренд (марка) автомобиля:",
                    "\nМодель:",
                    "\nЦвет:",
                    "\nЦена:"
            };
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Автосалон 'Grand-Auto'");
                Console.WriteLine("\n1. Добавить автомобиль");
                Console.WriteLine("2. Посмотреть какие машины в наличии");
                Console.WriteLine("3. Продать автомобиль");
                Console.WriteLine("4. Бюджет\n");

                int choose;
                try
                {
                    choose = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Введите число от 1 до 4!");
                    continue;
                }
                
                switch (choose)
                {
                    case 1:
                        try
                        {                            
                            CarAdd();
                        }
                        catch (Exception)
                        {

                            continue;
                        }                        
                        break;
                    case 2:

                    case 3:

                    case 4:

                    default:
                        break;
                }

                Console.ReadLine();
            }
        }
    }
}