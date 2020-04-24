using _3.Ingredients;
using _3.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace _3.Cooks
{
    public class Borshch : Cutting, ICookBorshch
    {
        Beet Beet = new Beet();
        Carrot Carrot = new Carrot();
        Meat Meat = new Meat();
        Onion Onion = new Onion();
        Potato Potato = new Potato();
       
        public string Dish = "Борщ";

        List<object> BoiledProductsForBorshch = new List<object>();
        List<object> FriedProductsForBorshch = new List<object>();

        public List<object> FryBorshch()
        {
            FriedProductsForBorshch.AddRange(new object[] { Beet, Meat, Carrot, Onion, Salt, Pepper, Spices });
            return FriedProductsForBorshch;
        }

        public List<object> BoilBorshch()
        {
            BoiledProductsForBorshch.AddRange(new object[] { Meat, Potato, Onion, Carrot });
            return BoiledProductsForBorshch;
        }
    }
}
