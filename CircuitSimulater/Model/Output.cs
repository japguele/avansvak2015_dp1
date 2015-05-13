using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircuitSimulater.Model
{
    class Output : BasicNodeInterface
    {
        private String name;

        public String getName()
        {
            return this.name;
        }
        public void setName(String name)
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
