using System;

namespace TRASH
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("Зеленое животное хищник, которое водится в водах Амазонии");
                Console.Write("Это - ");
                string AnswerUser = Console.ReadLine();
                bool CheckAnswer = AnswerUser == "Крокодил" ? true : false;
                Console.WriteLine(CheckAnswer);

                Console.ReadLine();
            }            
        }
    }
}