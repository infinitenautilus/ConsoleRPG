using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG.Core.Library.Components
{
    public class HealthComponent
    {
        int health, maxHealth = 100;

        public int GetHealth() { return health; }
        public int GetMaxHealth() { return maxHealth; }

        public string GetHealthStatusString() { return $"Health : {health.ToString()} ({maxHealth.ToString()})"; }

        public string GetHealthString() { return $"Health: {health.ToString()}"; }
        public string GetMaxHealthString() { return $"Max Health: {maxHealth.ToString()}"; }
    }
}
