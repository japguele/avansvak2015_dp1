using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircuitSimulator.Model
{
    public class Output : BasicNode
    {
        public static void Register()
        {
            CircuitFactory.Register("OUTPUT", typeof(Output));
        }

        public override void SetValue(Boolean input)
        {
            outputValue = input;

            Console.WriteLine(this.name + ": " + input);
        }
      
    }
}
