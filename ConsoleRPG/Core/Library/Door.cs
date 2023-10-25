using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG.Core.Library
{
    public class Door : Item
    {
        public Door() : base()
        {
            
        }

        public Door(string shortName, string desc) : base(shortName, desc)
        {
            ShortName = shortName;
            Description = desc;
        }

    }
}
