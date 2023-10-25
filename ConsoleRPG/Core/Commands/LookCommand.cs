using ConsoleRPG.Core.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleRPG.Core.GlobalFuncs;
using System.Globalization;

using static System.Console;


namespace ConsoleRPG.Core.Commands
{
    public class LookCommand : IRPGCommand
    {
        public string CommandName => "look";
        
        const int LastActorIndexOffset = 1;
        const int SecondLastActorIndexOffset = 2;

        public void ExecuteCommand(string input, Player user)
        {

            StringBuilder lookString = new();

            lookString.Append($"You look around you and see...\n{user.CurrentRoom.ShortName}\n{user.CurrentRoom.Description}\n");

            List<Actor> actorsInRoom = user.CurrentRoom.ListOfActors();
            actorsInRoom.Remove(user);

            StringBuilder actorDescription = GetActorLookList(actorsInRoom);

            if(actorDescription.Length > 1)
            {
                lookString.Append(actorDescription.ToString());
                lookString.Append("\n");
            }

            List<Item> itemsInRoom = user.CurrentRoom.ListOfItems();

            StringBuilder itemDescription = GetItemLookList(itemsInRoom);
            
            if(itemDescription.Length > 1)
            {
                lookString.Append(itemDescription.ToString());
                lookString.Append("\n");
            }

            List <RoomExit> exitsInRoom = user.CurrentRoom.RoomExits;

            StringBuilder exitString = GetRoomExitList(exitsInRoom);

            if(exitString.Length > 1)
            {
                lookString.Append(exitString.ToString());
                lookString.Append("\n");
            }

            Write(lookString.ToString());
        }

        public void HandleCommand(string command, Player user)
        {
            if(command.StartsWith(CommandName, StringComparison.OrdinalIgnoreCase))
            {
                ExecuteCommand(command, user);
            }
        }

        private StringBuilder GetActorLookList(List<Actor> actorsInRoom)
        {
            StringBuilder actorString = new StringBuilder();
            actorsInRoom.Sort((actor1, actor2) => string.Compare(actor1.ShortName, actor2.ShortName));

            for (int i = 0; i < actorsInRoom.Count; i++)
            {
                Actor actor = actorsInRoom[i];
                string actorDescription;

                if (actor.ProperNoun)
                {
                    actorDescription = actor.ShortName;
                }
                else
                {
                    actorDescription = $"{ArticleHelper.GetArticle(actor.ShortName)}{actor.ShortName}";
                }

                if (i == 0)
                {
                    actorDescription = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(actorDescription);
                }

                actorString.Append(actorDescription);

                if (i == actorsInRoom.Count - 1)
                {
                    actorString.Append(actorsInRoom.Count > 1 ? " are here." : " is here.");
                }
                else if (i == actorsInRoom.Count - 2)
                {
                    actorString.Append(", and ");
                }
                else
                {
                    actorString.Append(", ");
                }
            }

            return actorString;
        }


        private StringBuilder GetItemLookList(List<Item> itemsInRoom)
        {
            StringBuilder itemString = new StringBuilder();
            itemsInRoom.Sort((item1, item2) => string.Compare(item1.ShortName, item2.ShortName));

            for (int i = 0; i < itemsInRoom.Count; i++)
            {
                Item item = itemsInRoom[i];
                string itemDescription = $"{ArticleHelper.GetArticle(item.ShortName)}{item.ShortName}";

                if (i == 0)
                {
                    itemDescription = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(itemDescription);
                }

                itemString.Append(itemDescription);

                if (i == itemsInRoom.Count - 1)
                {
                    itemString.Append(".");
                }
                else if (i == itemsInRoom.Count - 2)
                {
                    itemString.Append(", and ");
                }
                else
                {
                    itemString.Append(", ");
                }
            }

            return itemString;
        }

        private StringBuilder GetRoomExitList(List<RoomExit> exitList)
        {
            StringBuilder exitString = new();

            if (exitList.Count == 0) 
            { 
                exitString.Append("There are no obvious exits."); 

                return exitString; 
            }

            exitString.Append("Obvious exits are: ");

            for(int i = 0; i < exitList.Count; i++)
            {
                RoomExit exit = exitList[i];
                
                string exitDescription = $"{exit.ExitName}";

                exitString.Append(exitDescription);

                if(i == exitList.Count - 1)
                {
                    exitString.Append(".");
                }
                else if(i == exitList.Count - 2)
                {
                    exitString.Append(", and ");
                }
                else
                {
                    exitString.Append(", ");
                }
            }

            return exitString;
        }

        private void AppendActorPresence(StringBuilder foo, int actorCount)
        {
            if(actorCount > 1)
            {
                foo.Append(" are here.");
            }
            else
            {
                foo.Append(" is here.");
            }
        }
    }
}
