using ConsoleRPG.Core.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG.Core.Commands
{
    public interface IRPGCommand
    {
        public string CommandName { get; }

        public void ExecuteCommand(string input, Player user);
        public void HandleCommand(string command, Player user);
    }
}
