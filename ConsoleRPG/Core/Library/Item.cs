using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG.Core.Library
{
    /// <summary>
    /// Tiny = Squirrel or smaller
    /// Small = Between a squirrel and a halfling (
    /// </summary>
    public enum ItemSize
    {
        Tiny = 0,
        Small = 1,
        Medium = 2,
        Large = 3,
        Huge = 4,
        Giant = 5
    }

    public class Item : Construct
    {
        private static int id = 0;
        public int ItemId { get; private set; }

        public int Weight = 1;
        public ItemSize MySize { get; set; }

        private int enchantValue = 0;
        
        public int EnchantmentValue 
        { 
            get { return enchantValue; } 
            set { enchantValue = value; } 
        }

        public bool CanBePickedUp = true;
        public bool CanBePutDown = true;
        public bool DropOnDeath = true;

        public Item()
        {

        }

        public Item(string shortDesc, string longDesc) : base(shortDesc, longDesc)
        {
            ShortName = shortDesc;
            Description = longDesc;
            enchantValue = 0;
            ItemId = id;
            id++;
        }

        public void Pulse()
        {

        }
    }
}
