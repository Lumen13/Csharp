using System;
using System.Collections.Generic;
using System.Text;

namespace _3
{
    class Dog : Animal, IAnimalCommands
    {

        public override string Type { get; set; }

        public void GetToOwner()
        {
            
        }

        public override void GetVoice()
        {

        }

        public bool SearchOwner()
        {
            return true;
        }
    }
}
