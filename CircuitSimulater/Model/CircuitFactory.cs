using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircuitSimulater.Model
{
    class CircuitFactory
    {
        private static Dictionary<string, Type> circuits = new Dictionary<string, Type>();

        public static void Register(String key, Type c)
        {
            circuits.Add(key, c);
        }

        public static BasicNode CreateNode(String key)
        { 
            Type type = null;
            if (circuits.TryGetValue(key, out type))
            {
                return (BasicNode)Activator.CreateInstance(type, null);
            }

            return null;
        }
    }
}
