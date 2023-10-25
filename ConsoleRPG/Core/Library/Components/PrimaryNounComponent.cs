using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG.Core.Library.Components
{
    public class PrimaryNounComponent
    {
        string primaryNoun;

        public PrimaryNounComponent(string noun)
        {
            primaryNoun = noun;
        }

        public string GetPrimaryNoun() { return primaryNoun; }
    }
}
