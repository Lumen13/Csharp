using System;
using System.Collections.Generic;
using System.Text;

namespace _3
{
    class Cat : Animal, IAnimalCommands
    {
        public void GetToOwner()
        {

        }

        public bool SearchOwner()
        {
            return true;
        }
        public override string Type { get; set; }

        public override void GetVoice()
        {

        }
    }
}
