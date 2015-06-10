using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircuitSimulator.Model
{
    public class Not : BasicNode
    {
        public static void Register()
        {
            CircuitFactory.Register("NOT", typeof(Not));
        }

        public override void SetValue(Boolean input)
        {
            this.SendValue(!input);         
        }
    }
}
