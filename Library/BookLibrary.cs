using System;
using System.Collections.Generic;
using System.Linq;
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

        string input_func(string user_help_notification)
        {
            Console.WriteLine(user_help_notification);
            string input_keyboard = Console.ReadLine();
            input_keyboard = input_keyboard.Trim(' ');
            while (string.IsNullOrWhiteSpace(input_keyboard))
            {
                Console.WriteLine("Ошибка ввода");
                input_keyboard = Console.ReadLine();
            }
            return input_keyboard;
        }

        private void add_book ()
        {            
            Book comicsbook = new Book()
            {
                author = input_func("Введите название книги:"),
                name = input_func("Введите фамилию автора:"),
                year = input_func("Год издания:"),
                book_text = input_func("О чём книга:")
            };
            
            Books.Add(comicsbook);
        }
        
        private void count_book ()
        {
            Console.WriteLine($"В библиотеке сейчас - {Books.Count} книг(а)");
        }

        public void run()
        {
            string welcomeLibrary = getBookLibraryInfo();
            Console.WriteLine(welcomeLibrary);

            string getBookLibraryInfo()
            {
                string result = "Добро пожаловать в нашу библиотеку которая находится по адресу:\n" + adress;
                result += $"\nМы работаем с {start_work_time} до {close_work_time}";

                return result;
            }            

            string input;
            bool check_input = true;
            
            while (check_input)
            {
                input = input_func("\nВведите:\n1 - добавить книгу, 2 - вывод кол-ва книг," +
                    "\n3 - вывод информации о первой книге, 0 - выйти из программы");
                switch (input)
                {
                    case "1":
                        add_book();
                        break;
                    case "2":
                        count_book();
                        break;
                    case "3":
                        write_first_book_to_cons();
                        break;
                    case "0":
                        check_input = false;
                        break;
                    default:
                        Console.WriteLine("Ошибка. Введите 1, 2, 3 или 0");
                        break;
                }
            }
        }

        public void write_first_book_to_cons ()
        {
            Book b1 = Books.FirstOrDefault();
            if (b1 == null)
            {
                Console.WriteLine("Сорян.. книг нет =(");
                return;
            }
            Console.WriteLine
                ($"\nНазвание книги - '{b1.name}'" +
                $"\nАвтор - '{b1.author}'" +
                $"\nКраткое содержание - '{b1.book_text}'" +
                $"\nДата выпуска - '{b1.year}'");
        }
    }
}

