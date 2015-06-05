using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircuitSimulater.Model
{
    class BasicNode : AbstractNode
    {
        public string name { get; set; }

        protected override void SendValue(bool output)
        {
            Mediator.getInstance().sendToNext(output, this);
        }
        public override void SetValue(bool input)
        {
            throw new NotImplementedException();
        }
        
    }
}
