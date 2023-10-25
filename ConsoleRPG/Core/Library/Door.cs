using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG.Core.Library
{
    public class Door : Construct
    {
        private static int id = 0;

        public int DoorId { get; private set; }

        public Door(string shortName, string desc) : base(shortName, desc)
        {
            ShortName = shortName;
            Description = desc;
            DoorId = id;
            id++;
        }

    }
}
