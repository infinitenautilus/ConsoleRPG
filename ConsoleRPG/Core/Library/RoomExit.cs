using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG.Core.Library
{
    public class RoomExit
    {
        public string ExitName { get; set; } = string.Empty;
        public string ExitFilePath { get; set; } = string.Empty;

        public bool DoorToExit { get; set; }

        public RoomExit(string exitName, string filePath, bool door)
        {
            ExitName = exitName;
            ExitFilePath = filePath;
            DoorToExit = door;
        }

    }
}
