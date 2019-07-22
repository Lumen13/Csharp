using System;
using System.Collections.Generic;

namespace Test1
{
    abstract class Animal
    {
        public string Name { get; set; }
        public bool Wool { get; set; }

        public Animal(string name, bool wool)
        {
            Name = name;
            Wool = wool;
        }

        public virtual void Print ()
        {
            Console.WriteLine(Name);
        }
        public abstract void wool_meth();
    }     

    class Dog : Animal
    {
        protected float speed;
        public Dog (float speed, string name, bool wool) : base (name, wool)
        {
            this.speed = speed; 
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Я Виртуальный метод и я ахуенен!");
            Console.WriteLine("Dog Speed: " + speed);
        }

        public override void wool_meth()
        {
            Console.WriteLine("Слыш, псина ");
            Console.WriteLine("Есть на жопе шерсть? " + Wool + "\n");
        }
    }

    class Cat : Animal
    {
        protected float speed;
        public Cat(float speed, string name, bool wool) : base(name, wool)
        {
            this.speed = speed;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Я Виртуальный метод и я ахуенен!");
            Console.WriteLine("Cat Speed: " + speed);
        }
        public override void wool_meth()
        {
            Console.WriteLine("Эй, котяра ");
            Console.WriteLine("Есть на жопе шерсть? " + Wool+ "\n");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            animals.Add(new Dog(12.23f, "SUKA", true));
            animals.Add(new Dog(5.80f, "KABEL'", true));
            animals.Add(new Cat(1.2f, "Впадлукот", false));

            foreach (Animal animal in animals)
            {
                animal.Print();
                if (animal is Dog)
                    Console.WriteLine("Собака - это животное\n");

                if (animal is Cat)
                    Console.WriteLine("Кошка - объебошка\n");
            }
            
            foreach (Animal animal in animals)
                animal.wool_meth();                    

            Console.ReadKey();         
        }
    }
}
