using System;

namespace Test1
{
    class Animal
    {
        public string Name { get; set; }

        public Animal(string name)
        {
            Name = name;
        }

        public void Print ()
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
            Console.WriteLine("Speed: " + speed);
        }        
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog jack = new Dog(12.23f, "Jack")
            {
                Name = "Jack"
            };
            Console.WriteLine(jack.Name + " ");
            jack.Print();

            Dog bob = new Dog(5.5f, "Bob")
            {
                Name = "Bob"
            };
            Console.WriteLine(bob.Name + " ");
            bob.Print();

            Console.ReadKey();         
        }
    }
}
