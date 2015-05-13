using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircuitSimulater.Model
{
    class Input : TwoInputNode
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
        public void setInput(Boolean startValue)
        {
            this.input = startValue;
        }
        public void SendInput()
        {
            if (this.input == true)
            {
                this.SendValueToNext(true);
            }
            else
            {            
                this.SendValueToNext(false);
            }
        }

    }
}
