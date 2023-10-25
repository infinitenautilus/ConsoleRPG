using ConsoleRPG.Core.Commands;
using ConsoleRPG.Core.Handlers;
using ConsoleRPG.Core.Library;
using System;
using static System.Console;

namespace ConsoleRPG.Core
{

    public class Program
    {
        public delegate void CommandHandlerDelegate(string command);
        public event CommandHandlerDelegate OnCommand = delegate { };
        Player player = new Player("You", "The player, so handsome.");

        bool runGame = true;

        private Program()
        {

        }

        static void Main(string[] args)
        {
            Program program = new();

            program.Start();
        }

        private void Start()
        {

            RegisterCommands();
            WriteLine("Loading...");

            Item rock = new Item("smelly rock", "A smelly rock.");
            Room thevoid = TheVoid.Instance;
            Agent guard = new Agent("City Guard", "This is a city guard.  He looks mean.");

            guard.MaxHealth = 1000;
            guard.Health = 1000;

            thevoid.ItemsInInventory.Add(rock);
            thevoid.AgentsInInventory.Add(guard);

            thevoid.PlayersInInventory.Add(player);
            player.CurrentRoom = thevoid;
            guard.CurrentRoom = thevoid;
            
            WriteLine("Current Room for Guard: " + guard.CurrentRoom.ToString());
            WriteLine("Current room for Player: " + player.CurrentRoom.ToString());    

            foreach(Actor a in player.CurrentRoom.ListOfActors())
            {
                WriteLine("Actor found in room: " + a.ShortName);
            }

            while (runGame)
            {
                WritePrompt();
                string? input = ReadLine();

                if (!string.IsNullOrWhiteSpace(input))
                {
                    ProcessInput(input, player);
                }
            }
        }

        
        public void QuitGame()
        {
            runGame = false;
        }

        private void RegisterCommands()
        {

            CommandHandler.Instance.RegisterCommand(new LookCommand());
            CommandHandler.Instance.RegisterCommand(new QuitCommand(this));
            
        }

        private void ProcessInput(string input, Player player)
        {
            if(string.IsNullOrWhiteSpace(input))
            {
                return;
            }

            CommandHandler.Instance.ExecuteCommand(input, player);
            OnCommand?.Invoke(input);
        }

        private void WritePrompt()
        {
            Write("> ");
        }

    }
}