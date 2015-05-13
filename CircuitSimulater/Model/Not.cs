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
        public void SendInput(Boolean input)
        {
            if (input)
            {
                input = false;
            }
            else
            {
                input = true;
            }
         this.SendValueToNext(false);

        }
    }
}
