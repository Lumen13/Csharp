using System;
using System.Collections.Generic;
using System.Text;
using TestInterface.cls;

namespace TestInterface.func
{
    class FList : Lists
    {
        private string input_string;
        public List <string> List_input_func()
        {            
            Console.WriteLine("Вас приветствует магазин 'PMS'!\nЧто бы вы хотели приобрести?");
            Console.WriteLine($"\n1. Планшет" +
                $"2. Стационарный персональный компьютер" +
                $"3. Ноутбук" +
                $"4. Телевизор" +
                $"5. Игровую консоль" +
                $"6. Смартфон");
            input_string = Console.ReadLine();
            return main_tech_list;
        }
    }
}