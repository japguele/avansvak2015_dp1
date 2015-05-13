using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircuitSimulater.Model
{
    class Output : BasicNodeInterface
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
        public void SetName(String name)
        {
            this.name = name;
        }
        public void SendInput(Boolean input)
        {
            int value =0;
            if(input){
                value = 1;
            }
            Console.WriteLine(value);
        }
    }
}
