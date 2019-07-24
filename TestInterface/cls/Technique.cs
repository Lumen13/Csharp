using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestInterface.intf;

namespace TestInterface.cls
{
    class Technique
    {
        private float price { get; set; }
        private bool share_event { get; set; }
        private string maker { get; set; }
        private int safeguard { get; set; }
        private float weight { get; set; }
        private List<Technique> parameters { get; set; }

        protected Technique(float _price, bool _share_event, string _maker,
            int _safeguard, float _weight)
        {
            parameters = new List<Technique>();
            price = _price;
            share_event = _share_event;
            maker = _maker;
            safeguard = _safeguard;
            weight = _weight;
        }              
    }
}
