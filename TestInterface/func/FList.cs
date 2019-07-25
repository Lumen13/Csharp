using System;
using System.Collections.Generic;
using System.Text;
using TestInterface.cls;
using TestInterface;

namespace TestInterface.func
{
    class FList : Lists
    {
        public List <string> List_input_func()
        {
            Lists Lists_object = new Lists();
            string input_string;
            Console.WriteLine($"Здравствуйте!" +
                "Вас приветствует магазин цифровой техники 'DNS'!\nЧто бы вы хотели приобрести?");
            Console.WriteLine($"\n1. Планшет" +
                $"\n2. Стационарный персональный компьютер" +
                $"\n3. Ноутбук" +
                $"\n4. Телевизор" +
                $"\n5. Игровую консоль" +
                $"\n6. Смартфон\n");
            input_string = Console.ReadLine();
            main_tech_list.Add(input_string);
            Console.WriteLine("\nСписок 'main_tech_list' содержит:");

            foreach (string i in main_tech_list)
            {
                Console.WriteLine(i);
            }

            return main_tech_list;            
        }
    }
}