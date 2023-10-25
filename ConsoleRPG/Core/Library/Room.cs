using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG.Core.Library
{
    public class Room : Construct
    {
        private static int id = 0;
        public int RoomId { get; private set; }

        public List<Item> ItemsInInventory { get; set; } = new();
        public List<Agent> AgentsInInventory { get; set; } = new();
        public List<Player> PlayersInInventory { get; set; } = new();

        public List<RoomExit> RoomExits { get; set; } = new();

        public Room() : base()
        {

        }

        public Room(string shortDesc, string longDesc) : base(shortDesc, longDesc)
        {
            ShortName = shortDesc;
            Description = longDesc;
            RoomId = id;
            id++;
        }

        public void Pulse()
        {

        }

        public List<Actor> ListOfActors()
        {
            List<Actor> actorList = new();
            
            foreach(Actor a in AgentsInInventory)
            {
                actorList.Add(a);
            }

            foreach(Actor a in PlayersInInventory)
            {
                actorList.Add(a);
            }

            return actorList;
        }

        public void AddExit(string directionOfExit, string exitFilePath, bool door)
        {
            RoomExit roomexit = new(directionOfExit, exitFilePath, door);
            
            RoomExits.Add(roomexit);
        }

        public List<Item> ListOfItems()
        {
            return ItemsInInventory;
        }
    }
}
