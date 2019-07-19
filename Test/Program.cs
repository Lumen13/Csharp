using System;
using System.Collections.Generic;

namespace Test
{
    public class Human
    {
        protected string creature;
        protected string institute;        

        protected Human(string _creature, string _institute)
        {
            creature = _creature;
            institute = _institute;
        }
    }
    class Student : Human
    {
        protected string name; 
        protected string faculty;
        protected int group;
        protected string gender;
        protected int age;
        protected bool grant;  
        
        protected Student(string _name, string _creature, string _institute, string _faculty,
            int _group, string _gender, int _age, bool _grant) : base (_creature, _institute)
        {
            name = _name;
            faculty = _faculty;
            group = _group;
            gender = _gender;
            age = _age;
            grant = _grant;
        }

        

        public void Output()
        {
            Console.WriteLine("Имя: " + name + " ");
            Console.WriteLine("Статус: " + creature + " ");
            Console.WriteLine("Универ: " + institute + " ");
            Console.WriteLine("Факультет: " + faculty + " ");
            Console.WriteLine("Группа: " + group + " ");
            Console.WriteLine("Гендер: " + gender + " ");
            Console.WriteLine("Возраст: " + age + " ");
            Console.WriteLine("Степуха: " + grant + "\n");
        }

        static void Main(string[] args)
        {
            Student Andrei = new Student("Андрей", "Студент", "СевГУ", "КиВТ", 740, "Мужик", 99, true);
            Student Alexey = new Student("Алексей", "Студент", "СевГУ", "ИиРТ", 740, "Парень", 22, true);
            Alexey.Output();
            Andrei.Output();

            Console.ReadKey();
        }
    }    
}




