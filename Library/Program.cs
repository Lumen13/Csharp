using System;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            BookLibrary bookLibrary = new BookLibrary("ул. Хуюкина 6", 10, 18);
            bookLibrary.run();         
            Console.ReadKey();
        }
    }
}
