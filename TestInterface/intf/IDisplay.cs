using System;
using System.Collections.Generic;
using System.Text;

namespace TestInterface.intf
{
    interface IDisplay
    {
        float resolution { get; set; }
        int diagonal { get; set; }
        int hdmi { get; set; }
        int thickness { get; set; }
        int usb { get; set; }
        bool bluetooth { get; set; }
    }
}
