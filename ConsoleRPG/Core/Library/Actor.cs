using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG.Core.Library
{
    public class Actor : Item
    {
        private static int id = 0;
        public int ActorId { get; private set; }

        public bool ProperNoun = false;

        public int Health, MaxHealth = 100;
        public int Energy, MaxEnergy = 100;

        public Room CurrentRoom = TheVoid.Instance;

        public Actor(string shortName, string longDesc) : base(shortName, longDesc)
        {
            ShortName = shortName;
            Description = longDesc;
            ActorId = id;
            id++;
        }
    }
}
