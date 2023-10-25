using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG.Core.Library
{
    public class Agent : Actor
    {
        private static int id = 0;
        public int AgentId { get; private set; }

        public Agent() : base()
        {

        }

        public Agent(string shortName, string description) : base(shortName, description)
        {
            ShortName = shortName;
            Description = description;
            AgentId = id;
            id++;
        }


    }
}
