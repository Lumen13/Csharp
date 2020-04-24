using _3.Ingredients;
using System;
using System.Collections.Generic;
using System.Text;

namespace _3
{
    public class Cutting
    {
        public string Salt = "Соль";
        public string Pepper = "Перец";
        public string Spices = "Специи";

        public List<object> Products()
        {
            List<object> products = new List<object>();
            Beet Beet = new Beet();
            Carrot Carrot = new Carrot();
            Meat Meat = new Meat();
            Onion Onion = new Onion();
            Potato Potato = new Potato();
            Rise Rise = new Rise();
            
            Beet.Name = "Свёкла";
            Carrot.Name = "Морковь";
            Meat.Name = "Мясо";
            Onion.Name = "Лук";
            Potato.Name = "Картошка";
            Rise.Name = "Рис";

            products.AddRange(new object[] { Beet, Carrot, Meat, Onion, Potato, Rise});

            return products;
        }
    }
}
