using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG.Core.Library
{
    public class Item : Construct
    {
        private static int id = 0;
        public int ItemId { get; private set; }

        public Item(string shortDesc, string longDesc) : base(shortDesc, longDesc)
        {
            ShortName = shortDesc;
            Description = longDesc;

            ItemId = id;
            id++;
        }

        public void Pulse()
        {

        }
    }
}
