using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircuitSimulater.Model
{
    class Input : TwoInputNode
    {
        public static void Register()
        {
            CircuitFactory.Register("INPUT", typeof(Input));
        }

        public override void SendValueToNext(Boolean input)
        {
            foreach (BasicNode node in Next)
            {
                node.SendValueToNext(input);
            }
        }
    }
}
