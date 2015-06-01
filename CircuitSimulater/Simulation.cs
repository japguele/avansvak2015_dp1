﻿using CircuitSimulater.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircuitSimulater
{
    class Simulation
    {
        public Simulation(Dictionary<string, string> nodes, Dictionary<string, string[]> edges)
        {
            Dictionary<string, BasicNode> nodeObjects = new Dictionary<string, BasicNode>();
            Dictionary<BasicNode, string> inputNodes = new Dictionary<BasicNode, string>();

            // Maak een node aan voor elke node
            foreach (var entry in nodes)
            {
                var nodeName = "";

                if (entry.Value == "INPUT_HIGH" || entry.Value == "INPUT_LOW")
                {
                    nodeName = "INPUT";
                }
                else if (entry.Value == "PROBE")
                {
                    nodeName = "OUTPUT";
                }
                else
                {
                    nodeName = entry.Value;
                }

                var node = CircuitFactory.CreateNode(nodeName);
                node.name = entry.Key;

                // Set value bij inputnode
                if (nodeName == "INPUT")
                {
                    inputNodes.Add(node, entry.Value);
                }

                nodeObjects.Add(entry.Key, node);
            }

            // Loop langs alle edges en voeg ze toe aan de node
            foreach (var entry in edges)
            {
                var node = nodeObjects[entry.Key];

                if (node != null)
                {
                    foreach (var destinationNode in entry.Value)
                    {
                        node.AddNext(nodeObjects[destinationNode]);
                    }
                }
            }

            foreach (var input in inputNodes)
            {
                
                if (input.Value == "INPUT_HIGH")
                {                 
                    input.Key.SendValueToNext(true);
                }
                else if (input.Value == "INPUT_LOW")
                {
                    input.Key.SendValueToNext(false);
                }
            }
        }
    }
}
