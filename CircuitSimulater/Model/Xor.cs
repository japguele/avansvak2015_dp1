using CircuitSimulator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircuitSimulator.Model
{
    public class Xor : TwoInputNode
    {
        public static void Register()
        {
            CircuitFactory.Register("XOR", typeof(Xor));
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
