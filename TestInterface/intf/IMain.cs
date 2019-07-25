using System;
using System.Collections.Generic;
using System.Text;

namespace TestInterface.intf
{
    interface IMain
    {
        float price { get; set; }
        bool share_event { get; set; }
        string maker { get; set; }
        int safeguard { get; set; }
        float weight { get; set; }
    }
}
