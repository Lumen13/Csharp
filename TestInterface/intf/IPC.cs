using System;
using System.Collections.Generic;
using System.Text;

namespace TestInterface.intf
{
    interface IPC
    {
        string processor { get; set; }
        string graphic { get; set; }
        int ram { get; set; }
        int ssd { get; set; }
        string motherboard { get; set; }
        string pc_case { get; set; }
        string power_unit { get; set; }
    }
}
