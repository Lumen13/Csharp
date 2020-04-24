using _3.Ingredients;
using _3.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _3.Cooks
{
    public class Pilaf : Cutting, ICookPilaf
    {
        Carrot Carrot = new Carrot();
        Meat Meat = new Meat();
        Onion Onion = new Onion();
        Potato Potato = new Potato();
        
        public string Dish = "Плов";

        List<object> BoiledProductsForPilaf = new List<object>();
        List<object> FriedProductsForPilaf = new List<object>();

        public List<object> FryPilaf()
        {
            FriedProductsForPilaf.AddRange(new object[] { Meat, Carrot, Onion, Salt, Pepper, Spices });
            return FriedProductsForPilaf;
        }

        public List<object> BoilPilaf()
        {
            BoiledProductsForPilaf.AddRange(new object[] { Meat, Potato, Onion, Carrot });
            return BoiledProductsForPilaf;
        }
    }
}
