using System;

namespace Hometask_calculator_1
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

            if (Operator == "+")
            {
                Console.WriteLine(FirstValue + SecondValue);
            }
            else if (Operator == "-")
            {
                Console.WriteLine(FirstValue - SecondValue);
            }
            else if (Operator == "*")
            {
                Console.WriteLine(FirstValue * SecondValue);
            }
            else if (Operator == "/")
            {
                Console.WriteLine(FirstValue / SecondValue);
            }
            else
            {
                Console.WriteLine("Ошибка! Неизвестный оператор");
            }
        }
    }
}
