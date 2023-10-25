using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleRPG.Core;
using ConsoleRPG.Core.Library;

namespace ConsoleRPG.Core.Library.World.Arlith.Rooms
{
    public class ArlithSmithy : Room
    {
        public ArlithSmithy() : base()
        {
            ShortName = "The Arlith Smithy";
            Description = "The dim interior of this smithy is illuminated by the flickering flames of a massive stone " +
                "hearth at it's center. Workbenches adorned with an array of hammers, tongs, and anvils surround the forge, while " +
                "shelves display raw materials.  Skilled blacksmiths and apprentices labor here with a purpose.";

            AddExit("south", "/Arlith/Rooms/Prospect_2.cs", true);

        }
    }
}
