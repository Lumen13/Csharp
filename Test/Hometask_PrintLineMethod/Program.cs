using System;

namespace Hometask_PrintLineMethod
{
    class Program
    {
        static string Concat(string InputString)
        {
            UInt32 Choose = 0;

            while (true)
            {
                Console.WriteLine($"\nВведите '1', чтобы закончить" +
                   $"\nВведите '2', чтобы добавить еще символов");
                try
                {
                    Choose = Convert.ToUInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("\nОшибка, необходимо ввести '1' или '2'");
                }

                if (Choose == 2)
                {
                    Console.WriteLine($"\nВводите символы и все они будут выведены в строку:");
                    InputString = string.Concat(InputString, Console.ReadLine());
                }
                else
                    return InputString;
            }
        }

        static void Main()
        {
            string EzString;

            Console.WriteLine($"\nВводите символы и все они будут выведены в строку:");
            EzString = Console.ReadLine();
            EzString = Concat(EzString);
            Console.WriteLine($"\nВаша строка - {EzString}");
        }
    }
}
