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
        private String name;

        public String GetName()
        {
            return this.name;
        }

        public override void SendValueToNext(Boolean input)
        {
          Console.WriteLine(input);
        }
      
    }
}
