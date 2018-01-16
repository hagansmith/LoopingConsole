using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopingConsole
{
    class Child
    {
        public string Name { get; set; }
        public bool Sick { get; set; }

        public string ForgeASickNote()
        {
            return Sick
               ? $"Plase excuse {Name} from class today because of illness"
               : $"{Name}, you still have to go to school";
        }
    }
}
