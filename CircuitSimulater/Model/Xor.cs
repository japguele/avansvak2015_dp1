using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircuitSimulater.Model
{
    class Xor : TwoInputNode
    {
        public static void Register()
        {
            CircuitFactory.Register("OUTPUT", typeof(Output));
        }

        public override void SetValue(Boolean input)
        {
             if (this.input == null)
            {
                this.input = input;
            }
            else
            {
                Boolean result = true;
                if (this.input == input)
                {
                    result = false;
                }
                this.SendValue(result);

            }
        }
    }
}
