using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircuitSimulater.Model
{
    public abstract class AbstractNode
    {
        public abstract void SendValueToNext(Boolean input);
    }
}
