using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleRPG.Core;
using ConsoleRPG.Core.Commands;
using ConsoleRPG.Core.Library;
using static System.Console;

namespace ConsoleRPG.Core.Handlers
{
    public class CommandHandler
    {
        private static readonly Lazy<CommandHandler> _instance = new Lazy<CommandHandler>(() => new CommandHandler());
        public static CommandHandler Instance = _instance.Value;

        private readonly Dictionary<string, IRPGCommand> _commands = new Dictionary<string, IRPGCommand>();

        private CommandHandler()
        {

        }

        public void RegisterCommand(IRPGCommand command)
        {
            _commands[command.CommandName] = command;
        }

        public void ExecuteCommand(string input, Player user)
        {
            string[] commandParts = input.Split(' ', 2);
            string commandName = commandParts[0];
            string commandArgs;

            if(commandParts.Length > 1)
            {
                commandArgs = commandParts[1];
            }
            else
            {
                commandArgs = string.Empty;
            }

            if(_commands.TryGetValue(commandName, out var command))
            {
                command.ExecuteCommand(commandArgs, user);
            }
            else
            {
                WriteLine("Command not found!");
            }
        }

    }
}
