using System;
using System.Globalization;

namespace MyStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            double dol = 64.42;
            double eur = 81.10;
            int a;
            double b, c, d;

            Console.WriteLine("Выберите тип валюты:\n" +
                "1. Рубли\n" +
                "2. Доллары\n" +
                "3. Евро");
            string str = (Console.ReadLine());
            bool result = Int32.TryParse(str, out a);
            if (result == true)
            {
                Console.WriteLine("\nВведите сумму:");
                string str2 = (Console.ReadLine());
                bool result2 = double.TryParse(str2, out b);
                if (result2 == true)
                {
                    switch (a)
                    {
                        case 1:
                            c = b / dol;
                            Console.WriteLine($"{b} руб = {Math.Round(c, 2)} дол");
                            c = b / eur;
                            Console.WriteLine($"{b} руб = {Math.Round(c, 2)} евр");
                            break;
                        case 2:
                            c = dol * b;
                            Console.WriteLine($"{b} дол = {Math.Round(c, 2)} руб");
                            d = c / eur;
                            Console.WriteLine($"{b} дол = {Math.Round(d, 2)} евр");
                            break;
                        case 3:
                            c = eur * b;
                            Console.WriteLine($"{b} евр = {Math.Round(c, 2)} руб");
                            d = c / dol;
                            Console.WriteLine($"{b} евр = {Math.Round(d, 2)} дол");
                            break;
                        default:
                            Console.WriteLine("\nОшибка! При выборе валют необходимо было ввести число от 1 до 3");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("\nОшибка! Введите сумму без букв");
                }
            }
            else
            {
                Console.WriteLine("\nОшибка! Введите число от 1 до 3");
            }
        }
    }
}
