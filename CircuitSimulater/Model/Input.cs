using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircuitSimulater.Model
{
    class Input : TwoInputNode
    {
        public static void Register()
        {
            CircuitFactory.Register("INPUT", typeof(Input));
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
        public void SetInput(Boolean startValue)
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
