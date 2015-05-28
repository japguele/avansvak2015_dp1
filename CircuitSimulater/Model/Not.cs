using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircuitSimulater.Model
{
    class Not : BasicNode
    {
        public static void Register()
        {
            CircuitFactory.Register("NOT", typeof(Not));
        }

        public override void SendValueToNext(Boolean input)
        {
            foreach (BasicNode node in Next)
            {
                node.SendValueToNext(!input);
            }           
        }
    }
}
