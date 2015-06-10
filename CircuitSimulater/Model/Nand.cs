using CircuitSimulator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircuitSimulator.Model
{
    public class Nand : TwoInputNode
    {
        public static void Register()
        {
            CircuitFactory.Register("NAND", typeof(Nand));
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
                if (this.input == true && input)
                {
                    result = false;
                }
                this.SendValue(result);

            }
        }
    }
}
