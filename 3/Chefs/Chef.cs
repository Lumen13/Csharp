using _3.Cooks;
using _3.Ingredients;
using _3.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _3.Chefs
{
    public class Chef : IReadyBorshch, IReadyPilaf, IReadyRagout
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        
        public Chef() { }

        public List<List<object>> FinishedDishBorshch(List<object> FriedProductsBorshch, List<object> BoiledProductsBorshch)
        {
            List<List<object>> CookedBorshch = new List<List<object>>();
            
            CookedBorshch.Add(FriedProductsBorshch);
            CookedBorshch.Add(BoiledProductsBorshch);

            return CookedBorshch;
        }

        public List<List<object>> FinishedDishPilaf(List<object> FriedProductsPilaf, List<object> BoiledProductsPilaf)
        {
            List<List<object>> CookedPilaf = new List<List<object>>();
            Pilaf pilaf = new Pilaf();

            FriedProductsPilaf = pilaf.FryPilaf();
            BoiledProductsPilaf = pilaf.BoilPilaf();
            CookedPilaf.Add(FriedProductsPilaf);
            CookedPilaf.Add(BoiledProductsPilaf);

            return CookedPilaf;
        }

        public List<List<object>> FinishedDishRagout(List<object> FriedProductsRagout, List<object> BoiledProductsRagout)
        {
            List<List<object>> CookedRagout = new List<List<object>>();
            Ragout ragout = new Ragout();

            FriedProductsRagout = ragout.FryRagout();
            BoiledProductsRagout = ragout.BoilRagout();
            CookedRagout.Add(FriedProductsRagout);
            CookedRagout.Add(BoiledProductsRagout);

            return CookedRagout;
        }
    }
}
