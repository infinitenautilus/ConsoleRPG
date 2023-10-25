using ConsoleRPG.Core.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleRPG.Core.GlobalFuncs;

using static System.Console;

namespace ConsoleRPG.Core.Commands
{
    public class LookCommand : IRPGCommand
    {
        public string CommandName => "look";
        
        public void ExecuteCommand(string input, Player user)
        {
            StringBuilder frog = new();
                        
            frog.Append("You look around you, and see...\n");
            frog.Append(user.CurrentRoom.ShortName + "\n");
            frog.Append(user.CurrentRoom.Description + "\n");

            //Get the actors names organized in alphabetical order
            List<Actor> actorsInRoom = user.CurrentRoom.ListOfActors();

            actorsInRoom.Remove(user);

            int index = 0;

            StringBuilder foo = new();

            if (actorsInRoom.Count == 1 && actorsInRoom[index].ProperNoun)
            {
                foo.Append($"{actorsInRoom[index].ShortName} is here.");                
            }
            else if(actorsInRoom.Count == 1 && !actorsInRoom[index].ProperNoun)
            {
                foo.Append($"{ArticleHelper.GetArticle(actorsInRoom[index].ShortName).ToUpper()}{actorsInRoom[index].ShortName} is here.");
            }
            else
            {
                foreach (Actor a in actorsInRoom)
                {

                    if (index == 0)
                    {
                        foo.Append($"{ArticleHelper.GetArticle(actorsInRoom[index].ShortName).ToUpper()}");
                    }

                    if(actorsInRoom.Count > 1)
                    {
                        if (actorsInRoom[index].ProperNoun)
                        {
                            foo.Append($"{actorsInRoom[index].ShortName}");
                        }
                        else
                        {
                            foo.Append($"{ArticleHelper.GetArticle(actorsInRoom[index].ShortName)}{actorsInRoom[index].ShortName}");
                        }

                        if(index == actorsInRoom.Count -1)
                        {
                            foo.Append(".");
                        }
                        else if(index == actorsInRoom.Count - 2)
                        {
                            foo.Append(", and ");
                        }
                        else
                        {
                            if(actorsInRoom.Count > 1)
                            {
                                foo.Append(" are here.");
                            }
                            else
                            {
                                foo.Append(" is here.");
                            }
                        }
                    }
                    index++;
                }
            }
           


            if(foo.Length > 1)
            {
                frog.Append(foo.ToString());
                frog.Append("\n");
            }

            List<Item> itemsInRoom = user.CurrentRoom.ListOfItems();

            foo = new();

            for(int i = 0;i < itemsInRoom.Count; i++)
            {
                if (i == 0)
                    foo.Append($"{ArticleHelper.GetArticle(itemsInRoom[i].ShortName).ToUpper()}{itemsInRoom[i].ShortName}");
                else
                    foo.Append($"{ArticleHelper.GetArticle(itemsInRoom[i].ShortName)}{itemsInRoom[i].ShortName}");

                if (i == itemsInRoom.Count - 1)
                {
                    foo.Append(".");
                }
               else if(i == itemsInRoom.Count - 2)
                {
                    foo.Append(", and ");
                }
               else
                {
                    foo.Append(", ");
                }

            }
            if(foo.Length > 1)
            {
                frog.Append(foo.ToString());
                frog.Append("\n");
            }

            WriteLine(frog.ToString());
        }

        public void HandleCommand(string command, Player user)
        {
            if(command.StartsWith(CommandName, StringComparison.OrdinalIgnoreCase))
            {
                ExecuteCommand(command, user);
            }
        }
    }
}
