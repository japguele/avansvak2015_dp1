using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircuitSimulater.Model
{
    class Mediator
    {
        private static Mediator instance;
        public static Mediator getInstance() {
           if (instance == null) {
            instance = new Mediator();                
           }
        
 
        return instance;
        }

        public void sendToNext(Boolean value, BasicNode from)
        {

        }
    }
}
