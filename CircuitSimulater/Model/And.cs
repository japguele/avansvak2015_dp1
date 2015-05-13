using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircuitSimulater.Model
{
    class And : TwoInputNode 
    {
        public override void SendInput(Boolean input)
        {
            if (this.input == null)
            {
                   this.input = input;
            }
            else
            {
                if (this.input == true && input == true)
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
}
