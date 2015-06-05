using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircuitSimulater.Model
{
    class Mediator
    {
        private Dictionary<BasicNode,BasicNode[]> dict =  new Dictionary<BasicNode,BasicNode[]>();
        private static Mediator instance;
        public static Mediator getInstance() {
           if (instance == null) {
            instance = new Mediator();                
           }
        
 
        return instance;
        }
        public void setDict(BasicNode node, BasicNode[] nodes){
            dict.Add(node,nodes);
        }
        public void cleanDict(){
        dict = new Dictionary<BasicNode,BasicNode[]>();
        }

        public void sendToNext(Boolean value, BasicNode from)
        {
           BasicNode[] nodes = dict[from];
            foreach(BasicNode node in nodes){
                node.SetValue(value);
            }

        }
    }
}
