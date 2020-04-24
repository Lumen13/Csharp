using _3.Ingredients;
using _3.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _3.Cooks
{
    public class Ragout : Cutting, ICookRagout
    {
        Carrot Carrot = new Carrot();
        Meat Meat = new Meat();
        Onion Onion = new Onion(); 

        public string Dish = "Овощное рагу";

        List<object> BoiledProductsForRagout = new List<object>();
        List<object> FriedProductsForRagout = new List<object>();

        public List<object> FryRagout()
        {
            BoiledProductsForRagout.AddRange(new object[] { Meat, Carrot, Onion, Salt, Pepper, Spices });
            return BoiledProductsForRagout;
        }

        public List<object> BoilRagout()
        {
            FriedProductsForRagout.AddRange(new object[] { Meat, Carrot, Onion, Salt, Pepper, Spices });
            return FriedProductsForRagout;
        }
    }
}
