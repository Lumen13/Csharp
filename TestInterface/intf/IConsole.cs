using System;
using System.Collections.Generic;
using System.Text;

namespace TestInterface.intf
{
    interface IConsole
    {
        bool full_digital { get; set; }
        int electro_library { get; set; }
        bool preorder_download { get; set; }
        int cloud_storage { get; set; }
    }
}
