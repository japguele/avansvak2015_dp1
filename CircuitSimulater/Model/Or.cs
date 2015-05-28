﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircuitSimulater.Model
{
    class Or : TwoInputNode
    {
        public static void Register()
        {
            CircuitFactory.Register("OR", typeof(Or));
        }

        public override void SendValueToNext(Boolean input)
        {
            if (this.input == null)
            {
                this.input = input;
            }
            else
            {
                if (this.input == true || input )
                {
                    foreach (BasicNode node in Next)
                    {
                        node.SendValueToNext(input);
                    }
                }
            }
        }
    }
}
