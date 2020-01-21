using System;

namespace RUBBISH2
{
    class Program
    {
        static void CarAdd(Cars cars)
        {
            for (int spec = 0; spec < 4; spec++) 
            {
                Console.WriteLine(cars.CarTextArray[spec]);
                cars.CarNewArray[spec] = Console.ReadLine();
                cars.CarAllArray[cars.CarsCounter, spec] = cars.CarNewArray[spec];
            }
            cars.CarsCounter++;
        }

        static void CarInfo(string [,] CarAllArray)
        {            
            Console.WriteLine();
            int row = CarAllArray.GetUpperBound(0) + 1;
            int column = CarAllArray.Length / row;            
            for (int i = 0; i < 4; i++)
            {
                if (CarAllArray[i,0] == null)
                {
                    continue;
                }
                for (int j = 0; j < column; j++)
                {                    
                    Console.WriteLine($"{CarAllArray[i, j]}");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        static void CarSell(string[,] CarAllArray)
        {
            for (int i = 0; i < CarAllArray.Length; i++)
            {
                if (i % 4 == 0)
                {
                    Console.WriteLine(CarAllArray[50, i]); // exception
                }
                Console.WriteLine();
            }   
        }

        static void Cash()
        {

        }        

        public class Cars
        {            
            public uint CarsCounter = 0;
            public string[,] CarAllArray = new string[50,4];
            public string[] CarNewArray = new string[4];
            public string[] CarTextArray = new string[4]
            {
                    "\nБренд (марка) автомобиля:",
                    "\nМодель:",
                    "\nЦвет:",
                    "\nЦена:"
            };
        }

        static void Main()
        {
            Cars cars = new Cars();
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
                        CarAdd(cars);
                        continue;
                    case 2:
                        CarInfo(cars.CarAllArray);
                        continue;
                    case 3:
                        CarSell(cars.CarAllArray);
                        continue;
                    case 4:

                    default:
                        break;
                }

                Console.ReadLine();
            }
        }
    }
}