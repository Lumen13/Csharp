using System;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            BookLibrary bookLibrary = new BookLibrary("ул. Хуюкина 6", 10, 18);             
            string welcomeLibrary = bookLibrary.getBookLibraryInfo();
            Console.WriteLine(welcomeLibrary);
            bookLibrary.add_book();
            bookLibrary.count_book();
            
            /*
             * while, switch-case;
             * набить книг;
             * функция - названия всех книг; 
             * функция - ввод книг из консоли;
             */

        }
    }
}
