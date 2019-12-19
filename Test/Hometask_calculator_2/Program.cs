using System;

namespace Hometask_calculator_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 1 число");
            double FirstValue = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите символ математической операции (+ - * /)");
            string Operator = Console.ReadLine();
            Console.WriteLine("Введите 2 число");
            double SecondValue = double.Parse(Console.ReadLine());

            switch (Operator)
            {
                case "+":
                    Console.WriteLine(FirstValue+SecondValue);
                    break;
                case "-":
                    Console.WriteLine(FirstValue-SecondValue);
                    break;
                case "*":
                    Console.WriteLine(FirstValue*SecondValue);
                    break;
                case "/":
                    Console.WriteLine(FirstValue/SecondValue);
                    break;
                default:
                    Console.WriteLine("Ошибка ввода!");
                    break;
            }
        }
    }
}
