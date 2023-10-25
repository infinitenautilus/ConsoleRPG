using ConsoleRPG.Core.Handlers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG.Core.Library
{
    public class TheVoid : Room
    {
        private static readonly Lazy<TheVoid> instance = new Lazy<TheVoid>(() => new TheVoid("The Void", "This is the void.  " +
            "All things end up here when they're lost."));

        public static TheVoid Instance { get { return instance.Value; } }

        public TheVoid(string name, string description) : base(name, description)
        {
            ShortName = name;
            Description = description;
        }
    }
}
