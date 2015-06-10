using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircuitSimulator.Model
{
    public class Or : TwoInputNode
    {
        public static void Register()
        {
            CircuitFactory.Register("OR", typeof(Or));
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
                if (this.input == true || input)
                {
                    result = true;
                }
                this.SendValue(result);
            }
        }
    }
}
