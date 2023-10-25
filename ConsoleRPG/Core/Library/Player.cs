using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG.Core.Library
{
    public class Player : Actor
    {
        private static int id = 0;
        public int PlayerId { get; private set; }


        public Player(string shortName, string desc) : base(shortName, desc) 
        {
            ShortName = shortName;
            Description = desc;
            PlayerId = id;
            id++;

            CurrentRoom = new("Nowhere", "You are nowhere.  This shouldn't happen.");
        }

        public new void Pulse()
        {

        }
    }
}
