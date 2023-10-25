using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG.Core.Library.World.Arlith.Rooms
{
    public class Prospect_2 : Room
    {
        public Prospect_2() : base()
        {
            ShortName = "Prospect Street - South of the Smithy";
            Description = "The cobbleroad street runs east and west beneath your feet.  To the north is a structure you identify as a smithy, steam billows out of a vent on the roof.";
            
            AddExit("north", "/Arlith/Rooms/Smithy.cs", true);
        }
    }
}
