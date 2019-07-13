using System;
using System.Collections.Generic;
using System.Text;
using Library.Models;

namespace Library
{
    public class BookLibrary
    {
        private string adress;
        private int start_work_time;
        private int close_work_time;
        private List<Book> Books;

        public BookLibrary(string _adress, int _start_work_time, int _close_work_time)
        {
            Books = new List<Book>();
            adress = _adress;
            start_work_time = _start_work_time;
            close_work_time = _close_work_time;
        }
      
        public string getBookLibraryInfo()
        {
            string result = "Добро пожаловать в нашу библиотеку которая находится по адресу: " + adress;
            result += $"\nМы работаем с {start_work_time} до {close_work_time}";

            return result;
        }

        public void add_book ()
        {
            Book comicsbook = new Book()
            {
                author = "Гоголь",
                book_text = "Жили были, всё пропили",
                name = "Цвет настроения синий",
                year = 1111               
            };

            Books.Add(comicsbook);
        }
        
        public void count_book ()
        {
            Console.WriteLine($"В библиотеке сейчас - {Books.Count} книг(а)");
        }

    }
}
