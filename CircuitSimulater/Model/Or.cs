using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircuitSimulater.Model
{
    class Or : TwoInputNode
    {
        public override void SendInput(Boolean input)
        {
            if (this.input == null)
            {
                this.input = input;
            }
            else
            {
                if (this.input == false && input == false)
                {
                    this.SendValueToNext(false);
                }
                else
                {
                    this.SendValueToNext(true);
                }


            }

        }
    }
}
