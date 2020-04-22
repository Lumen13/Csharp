using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            var myDog = new Dog();
            var myCat = new Cat();
            var myCow = new Cow();
            var myList = new List<IAnimalCommands>();

            myList.Add(myDog);
            myList.Add(myCat);
            myList.Add(myCow);

            for (int i = 0; i < myList.Count; i++)
            {
                var myAnimal = myList[i];
                var dog = myAnimal as Dog;
                if (dog != null)
                {
                    Console.WriteLine($"Вот это - собака!");
                }
                else
                {
                    var cat = myAnimal as Cat;
                    if (cat != null)
                    {
                        Console.WriteLine($"Вот это - кошка!");
                    }
                    else
                    {
                        Console.WriteLine($"пиздец.. (");
                    }
                }
            }
        }
    }

    // _____________________________________________________________
    // _______________   TEST ______________________________________
    // _____________________________________________________________

    public class Kassirsha
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int WorkAge { get; set; }

        ICalculator calculator;

        public Kassirsha(ICalculator _objCalculator)
        {
            calculator = _objCalculator;
        }

        public void Count()
        {
            int[] chaos = new int[5] { 12, 44, 31, 222, 0 };
            int result = calculator.Calculate(chaos);
            Console.WriteLine(result);
        }
    }

    public interface ICalculator
    {
        int Calculate(int[] price);
    }

    public class CalculatorNtapV1 : ICalculator
    {
        public int Calculate(int[] price)
        {
            int result = 0;
            for (int i = 0; i < price.Length; i++)
            {
                result += price[i];
            }
            return result;
        }
    }

    public class CalculatorNtapV2 : ICalculator
    {
        public int Calculate(int[] price)
        {
            int result = 0;
            for (int i = 0; i < price.Length; i++)
            {
                result += price[i];
            }
            return result;
        }
    }

    public class Shop
    {
        public void Work()
        {
            CalculatorNtapV1 calculatorNtapV1 = new CalculatorNtapV1();
            CalculatorNtapV2 calculatorNtapV2 = new CalculatorNtapV2();
            Kassirsha kassirsha = new Kassirsha(calculatorNtapV1);
            Kassirsha kassirsha2 = new Kassirsha(calculatorNtapV2);
        }
    }
}
