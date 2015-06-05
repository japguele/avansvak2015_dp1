using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircuitSimulater.Model
{
    class Output : BasicNode
    {
        public static void Register()
        {
            CircuitFactory.Register("OUTPUT", typeof(Output));
        }

        public override void SetValue(Boolean input)
        {
          Console.WriteLine(this.name + ": " + input);
        }
      
    }
}
