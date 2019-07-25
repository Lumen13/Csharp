using System;
using System.Collections.Generic;
using System.Text;

namespace TestInterface.intf
{
    interface IPortable
    {
        string network_standart { get; set; }
        bool gps { get; set; }
        bool double_sim { get; set; }
        bool IPS { get; set; }
    }
}
