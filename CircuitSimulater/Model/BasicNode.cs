using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircuitSimulater.Model
{
    class BasicNode : BasicNodeInterface
    {
        private String name;
        private List<BasicNodeInterface> Next = new List<BasicNodeInterface>();
     
        public void AddNext(BasicNodeInterface Next)
        {
            this.Next.Add(Next);
        }

        protected void SendValueToNext(Boolean output)
        {
            foreach (BasicNodeInterface node in Next)
            {
                node.SendInput(output);
            }
           
        }

        public virtual void SendInput(Boolean input)
        {
        }
        public void setName(String name)
        {
            this.name = name;
        }

        
    }
}
