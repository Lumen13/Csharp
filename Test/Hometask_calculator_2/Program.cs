using System;

namespace Hometask_calculator_2
{
    class Program
    {
        static void Main(string[] args)
        {            
            double FirstValue, SecondValue;
            string Operator;

            while (true)
            {
                Console.Clear();

                try
                {
                    Console.WriteLine("Введите 1 число");
                    FirstValue = double.Parse(Console.ReadLine());                    
                }
                catch (Exception)
                {
                    Console.WriteLine("Ошибка! Необходимо ввести число");
                    Console.ReadLine();
                    continue;
                }

                Console.WriteLine("Введите символ математической операции (+ - * /)");
                Operator = Console.ReadLine();

                try
                {
                    Console.WriteLine("Введите 2 число");
                    SecondValue = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Ошибка! Необходимо ввести число");
                    continue;
                }

                switch (Operator)
                {
                    case "+":
                        Console.WriteLine(FirstValue + SecondValue);
                        break;
                    case "-":
                        Console.WriteLine(FirstValue - SecondValue);
                        break;
                    case "*":
                        Console.WriteLine(FirstValue * SecondValue);
                        break;
                    case "/":
                        if (SecondValue == 0)
                        {
                            Console.WriteLine("Ошибка деления на 0!");
                            break;
                        }
                        Console.WriteLine(FirstValue / SecondValue);
                        break;
                    default:
                        Console.WriteLine("Ошибка ввода операции!");
                        break;
                }

                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
