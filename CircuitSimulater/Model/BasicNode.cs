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
        protected List<BasicNode> Next = new List<BasicNode>();

        public void AddNext(BasicNode Next)
        {
            this.Next.Add(Next);
        }

        public override void SendValueToNext(Boolean input)
        {
        }      
    }
}
