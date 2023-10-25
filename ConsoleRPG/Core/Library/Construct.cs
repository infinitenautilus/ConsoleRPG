using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG.Core.Library
{
    public class Construct
    {
        public string ShortName { get; set; } = "Construct";
        public string Description { get; set; } = "The construct class itself.";

        private static int id = 0;
        
        public int ConstructId { get; private set; }

        public Construct()
        {

        }

        public Construct(string primaryNoune, string desc)
        {
            ShortName = primaryNoune;
            Description = desc;

            ConstructId = id;
            id++;
        }

    }
}
