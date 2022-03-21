using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03
{
    internal class Cow : Animal
    {
        public Cow(string name, string habitat, string sound, Int32 weight, Int32 height) : base(name, habitat, sound, weight, height)
        {
            Sound = "moo";
        }
    }
}
