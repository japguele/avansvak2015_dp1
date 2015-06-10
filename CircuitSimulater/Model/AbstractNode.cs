using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircuitSimulator.Model
{
    public abstract class AbstractNode
    {
        public abstract void SetValue(Boolean input);
        protected abstract void SendValue(Boolean output);
    }
}
