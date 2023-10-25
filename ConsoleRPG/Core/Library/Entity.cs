using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG.Core.Library
{
    public class Entity
    {
        private static int id = 0;
        public int EntityId { get; private set; }

        private Dictionary<Type, object> components = new();


        public Entity()
        {
            EntityId = id;
            id++;
        }

        public T GetComponent<T>()
        {
            Type type = typeof(T);
            if(components.ContainsKey(type))
            {
                return (T)components[type];
            }

            return default(T);
        }

        public void AddComponent<T>(T component)
        {
            Type type = typeof(T);

            if(!components.ContainsKey(type))
            {
                components[type] = component;
            }
        }
    }
}
