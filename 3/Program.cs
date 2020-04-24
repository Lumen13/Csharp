using _3.Chefs;
using _3.Cooks;
using _3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Reflection;
using System.Dynamic;
using _3.Ingredients;

namespace _3
{
    public class Program
    {
        static void Main()
        {
            ICookBorshch cookBorshch = new Borshch();
            ICookPilaf cookPilaf = new Pilaf();
            ICookRagout cookRagout = new Ragout();
            IReadyBorshch readyBorshch = new Chef();
            IReadyPilaf readyPilaf = new Chef();
            IReadyRagout readyRagout = new Chef();

            Chef Kolya = new Chef
            {
                Age = 40,
                Name = "Колян"
            };

            Chef Vitya = new Chef
            {
                Age = 35,
                Name = "Витёк"
            };

            Chef Vasya = new Chef
            {
                Age = 25,
                Name = "Васька"
            };

            Borshch borshch = new Borshch();
            Pilaf pilaf = new Pilaf();
            Ragout ragout = new Ragout();
            Cutting cut = new Cutting();

            Beet beet = new Beet();
            Carrot carrot = new Carrot();
            Meat meat = new Meat();
            Onion onion = new Onion();
            Potato potato = new Potato();
            Rise rise = new Rise();

            List<object> friedBorshch = cookBorshch.FryBorshch();
            List<object> boiledBorshch = cookBorshch.BoilBorshch();
            List<object> friedPilaf = cookPilaf.FryPilaf();
            List<object> boiledPilaf = cookPilaf.BoilPilaf();
            List<object> friedRagout = cookRagout.FryRagout();
            List<object> boiledRagout = cookRagout.BoilRagout();

            List<List<object>> readyBorshchDish = readyBorshch.FinishedDishBorshch(friedBorshch, boiledBorshch);
            List<List<object>> readyPilafDish = readyPilaf.FinishedDishPilaf(friedPilaf, boiledPilaf);
            List<List<object>> readyRagoutDish = readyRagout.FinishedDishRagout(friedRagout, boiledRagout);

            cut.Products();            

            Console.WriteLine($"Сегодняшние повара:" +
                $"\n\n{Kolya.Name} ({Kolya.Age} лет), {Vasya.Name} ({Vasya.Age} лет) и {Vitya.Name} ({Vitya.Age} лет)" +
                $"\n\nОни приготовили сегодня:" +
                $"\n{borshch.Dish}, {pilaf.Dish}, {ragout.Dish}" +
                $"\n\nРецепт такой:" +
                $"\n\n{beet.Name} - {beet.Weight} кг" +
                $"\n{carrot.Name} - {carrot.Weight} кг" +
                $"\n{meat.Name} - {meat.Weight} (тип {meat.Type}) кг" +
                $"\n{onion.Name} - {onion.Weight}" +
                $"\n{potato.Name} - {potato.Weight}" +
                $"\n{rise.Name} - {rise.Weight} (тип {rise.Type}) кг" +
                $"\n{cut.Pepper}" +
                $"\n{cut.Salt}" +
                $"\n{cut.Spices}");
            Console.WriteLine("\n\nГотовили блюда следующим образом:");

            foreach (var mainList in readyBorshchDish)
            {
                foreach (var item in mainList)
                {
                    Console.WriteLine("");
                    Console.WriteLine($"{item}");
                }
            }
        }
    }
}