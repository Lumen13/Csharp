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

        static double CarSell(string[,] CarAllArray)
        {
            Console.WriteLine();
            //uint FirstCounter = 0;            
            double sum = 0, elem = 0;                           
            Console.WriteLine($"Вы продали:");
            for (ushort column = 0; column < 50; column++)
            {
                if (CarAllArray[column, 0] == null)
                {
                    break;
                }
                for (ushort line = 0; line < 4; line++)
                {                    
                    if (line == 3)
                    {
                        elem = Convert.ToDouble(CarAllArray[column, line]);
                        sum += elem;
                        Console.Write($" - продан за {CarAllArray[column, line]}$\n");
                        CarAllArray[column, line] = null;
                    }
                    else
                    {
                        Console.Write($"{CarAllArray[column, line]} ");
                        CarAllArray[column, line] = null;
                    }                        
                }                
            }
            Console.ReadLine();
            return sum;
        }

        static void Cash(double sum)
        {
            Console.WriteLine($"\nИТОГО: Вы заработали {sum}$!");
            Console.ReadLine();
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
            double sum = 0;
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
                        sum = CarSell(cars.CarAllArray);
                        continue;
                    case 4:
                        Cash(sum);
                        continue;
                    default:
                        break;
                }

                Console.ReadLine();
            }
        }
    }
}