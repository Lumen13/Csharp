using System;
using System.Collections.Generic;

namespace Test1
{
    class Animal
    {
        public string Name { get; set; }

        public Animal(string name)
        {
            Name = name;
        }

        public virtual void Print ()
        {
            Console.WriteLine(Name);
        }
    }
    class Dog : Animal
    {
        protected float speed;
        public Dog (float speed, string name) : base (name)
        {
            this.speed = speed;            
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Я Виртуальный метод и я ахуенен!");
            Console.WriteLine("Dog Speed: " + speed);
        }
    }

    class Cat : Animal
    {
        protected float speed;
        public Cat(float speed, string name) : base(name)
        {
            this.speed = speed;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Я Виртуальный метод и я ахуенен!");
            Console.WriteLine("Cat Speed: " + speed);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            animals.Add(new Dog(12.23f, "SUKA"));
            animals.Add(new Dog(5.80f, "KABEL'"));
            animals.Add(new Cat(1.2f, "Впадлукот"));

            foreach (Animal animal in animals)
            {
                animal.Print();
                if (animal is Dog)
                    Console.WriteLine("Собака - это животное\n");

                if (animal is Cat)
                    Console.WriteLine("Кошка - объебошка\n");
            }
           
            Console.ReadKey();         
        }
    }
}
