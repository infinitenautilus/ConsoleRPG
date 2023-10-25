using ConsoleRPG.Core.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG.Core.Commands
{
    public class QuitCommand : IRPGCommand
    {
        private Program _program; 

        public string CommandName => "quit";

        public void ExecuteCommand(string input, Player user)
        {
            Console.WriteLine("Goodbye.");
            _program.QuitGame();
        }

        public void HandleCommand(string command, Player user)
        {
            Console.WriteLine("Goodbye.");
            
            _program.QuitGame();
        }

        public QuitCommand(Program program)
        {
            _program = program;
            
        }
    }
}
