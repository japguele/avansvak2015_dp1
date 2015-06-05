using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircuitSimulater.Model
{
    class And : TwoInputNode 
    {
        public static void Register()
        {
            CircuitFactory.Register("AND", typeof(And));
        }

        public override void SetValue(Boolean input)
        {
            //Console.WriteLine("and gate");
            if (this.input == null)
            {
                this.input = input;
            }
            else
            {
                
                Boolean result = false;
                if (this.input == true && input)
                {
                    result = true;
                }
                this.SendValue(result);
                           
            }
        }
    }
}
