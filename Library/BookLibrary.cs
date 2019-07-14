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
      
        private string getBookLibraryInfo()
        {
            string result = "Добро пожаловать в нашу библиотеку которая находится по адресу:\n" + adress;
            result += $"\nМы работаем с {start_work_time} до {close_work_time}";

            return result;
        }

        private void add_book ()
        {
            Console.WriteLine("Введите название книги:");
            string input_bookname = Console.ReadLine();
            input_bookname = input_bookname.Trim(' ');
            if (string.IsNullOrWhiteSpace(input_bookname))
            {
                Console.WriteLine("Ошибка ввода");
                return;
            }

            Console.WriteLine("Введите фамилию автора:");
            string input_authorname = Console.ReadLine();
            input_authorname = input_authorname.Trim(' ');
            if (string.IsNullOrWhiteSpace(input_authorname))
            {
                Console.WriteLine("Ошибка ввода");
                return;
            }

            Console.WriteLine("Год издания:");
            string input_bookyear = Console.ReadLine();
            input_bookyear = input_bookyear.Trim(' ');
            if (string.IsNullOrWhiteSpace(input_bookyear))
            {
                Console.WriteLine("Ошибка ввода");
                return;
            }

            Console.WriteLine("О чём книга?");
            string input_bookinfo = Console.ReadLine();
            input_bookinfo = input_bookinfo.Trim(' ');
            if (string.IsNullOrWhiteSpace(input_bookinfo))
            {
                Console.WriteLine("Ошибка ввода");
                return;
            }
         
            Book comicsbook = new Book()
            {
                author = input_authorname,
                name = input_bookname,
                year = input_bookyear,
                book_text = input_bookinfo
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

            string input;
            bool check_input = true;
            
            while (check_input)
            {
                Console.WriteLine("\nВведите:\n1 - добавить книгу, 2 - вывод кол-ва книг,\n3 - вывод информации о первой книге, 0 - выйти из программы");
                input = Console.ReadLine();
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

