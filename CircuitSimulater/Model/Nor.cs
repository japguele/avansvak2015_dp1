using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircuitSimulater.Model
{
    class Nor : TwoInputNode
    {
        public static void Register()
        {
            CircuitFactory.Register("Nor", typeof(Nor));
        }

        public override void SetValue(Boolean input)
        {
            if (this.input == null)
            {
                this.input = input;
            }
            else
            {
                Boolean result = false;
                if (this.input == false && !input)
                {
                    result = true;
                }
                this.SendValue(result);

            }
        }
    }
}
