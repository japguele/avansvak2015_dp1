using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CircuitSimulator;
using System.Collections.Generic;
using CircuitSimulator.Model;

namespace UnitTestProject
{
    [TestClass]
    public class NodeTests
    {
        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            And.Register();
            Input.Register();
            Not.Register();
            Or.Register();
            Output.Register();
        }

        [TestMethod]
        public void TestAndNode()
        {
            Mediator currentMediator = Mediator.getInstance();

            var inputNode1 = CircuitFactory.CreateNode("INPUT");
            inputNode1.name = "IN1";

            var inputNode2 = CircuitFactory.CreateNode("INPUT");
            inputNode2.name = "IN2";

            var andNode = CircuitFactory.CreateNode("AND");
            andNode.name = "ANDNODE";

            var outputNode = CircuitFactory.CreateNode("OUTPUT");
            outputNode.name = "Out";

            currentMediator.setDict(inputNode1, new BasicNode[] { andNode });
            currentMediator.setDict(inputNode2, new BasicNode[] { andNode });
            currentMediator.setDict(andNode, new BasicNode[] { outputNode });

            inputNode1.SetValue(true);
            inputNode2.SetValue(false);

            Assert.AreEqual(outputNode.outputValue, false);
        }

        [TestMethod]
        public void TestOrNode()
        {
            Mediator currentMediator = Mediator.getInstance();

            var inputNode1 = CircuitFactory.CreateNode("INPUT");
            inputNode1.name = "IN1";

            var inputNode2 = CircuitFactory.CreateNode("INPUT");
            inputNode2.name = "IN2";

            var orNode = CircuitFactory.CreateNode("OR");
            orNode.name = "ORNODE";

            var outputNode = CircuitFactory.CreateNode("OUTPUT");
            outputNode.name = "Out";

            currentMediator.setDict(inputNode1, new BasicNode[] { orNode });
            currentMediator.setDict(inputNode2, new BasicNode[] { orNode });
            currentMediator.setDict(orNode, new BasicNode[] { outputNode });

            inputNode1.SetValue(true);
            inputNode2.SetValue(false);

            Assert.AreEqual(outputNode.outputValue, true);
        }

        [TestMethod]
        public void TestInputNode()
        {
            Mediator currentMediator = Mediator.getInstance();

            var inputNode1 = CircuitFactory.CreateNode("INPUT");
            inputNode1.name = "IN1";

            var outputNode = CircuitFactory.CreateNode("OUTPUT");
            outputNode.name = "Out";

            currentMediator.setDict(inputNode1, new BasicNode[] { outputNode });

            inputNode1.SetValue(true);

            Assert.AreEqual(outputNode.outputValue, true);
        }

        [TestMethod]
        public void TestNotNode()
        {
            Mediator currentMediator = Mediator.getInstance();

            var inputNode1 = CircuitFactory.CreateNode("INPUT");
            inputNode1.name = "IN1";

            var notNode = CircuitFactory.CreateNode("NOT");
            notNode.name = "NOTNODE";

            var outputNode = CircuitFactory.CreateNode("OUTPUT");
            outputNode.name = "Out";

            currentMediator.setDict(inputNode1, new BasicNode[] { notNode });
            currentMediator.setDict(notNode, new BasicNode[] { outputNode });

            inputNode1.SetValue(true);

            Assert.AreEqual(outputNode.outputValue, false);
        }

        [TestMethod]
        public void TestOutputNode()
        {
            Mediator currentMediator = Mediator.getInstance();

            var inputNode1 = CircuitFactory.CreateNode("INPUT");
            inputNode1.name = "IN1";

            var outputNode = CircuitFactory.CreateNode("OUTPUT");
            outputNode.name = "Out";

            currentMediator.setDict(inputNode1, new BasicNode[] { outputNode });

            inputNode1.SetValue(true);

            Assert.AreEqual(outputNode.outputValue, true);
        }

        [TestMethod]
        public void TestFullAdder()
        {
            Mediator currentMediator = Mediator.getInstance();

            var a = CircuitFactory.CreateNode("INPUT");
            a.name = "A";

            var b = CircuitFactory.CreateNode("INPUT");
            b.name = "B";

            var cin = CircuitFactory.CreateNode("INPUT");
            cin.name = "Cin";

            var cout = CircuitFactory.CreateNode("OUTPUT");
            cout.name = "Cout";

            var s = CircuitFactory.CreateNode("OUTPUT");
            s.name = "S";

            var node1 = CircuitFactory.CreateNode("OR");
            node1.name = "NODE1";

            var node2 = CircuitFactory.CreateNode("AND");
            node2.name = "NODE2";

            var node3 = CircuitFactory.CreateNode("AND");
            node3.name = "NODE3";

            var node4 = CircuitFactory.CreateNode("NOT");
            node4.name = "NODE4";

            var node5 = CircuitFactory.CreateNode("AND");
            node5.name = "NODE5";

            var node6 = CircuitFactory.CreateNode("OR");
            node6.name = "NODE6";

            var node7 = CircuitFactory.CreateNode("NOT");
            node7.name = "NODE7";

            var node8 = CircuitFactory.CreateNode("NOT");
            node8.name = "NODE8";

            var node9 = CircuitFactory.CreateNode("AND");
            node9.name = "NODE9";

            var node10 = CircuitFactory.CreateNode("AND");
            node10.name = "NODE10";

            var node11 = CircuitFactory.CreateNode("OR");
            node11.name = "NODE11";

            currentMediator.setDict(cin, new BasicNode[] { node3, node7, node10 });
            currentMediator.setDict(a, new BasicNode[] { node1, node2 });
            currentMediator.setDict(b, new BasicNode[] { node1, node2 });
            currentMediator.setDict(node1, new BasicNode[] { node3, node5 });
            currentMediator.setDict(node2, new BasicNode[] { node4, node6 });
            currentMediator.setDict(node3, new BasicNode[] { node6 });
            currentMediator.setDict(node4, new BasicNode[] { node5 });
            currentMediator.setDict(node5, new BasicNode[] { node8, node9 });
            currentMediator.setDict(node6, new BasicNode[] { cout });
            currentMediator.setDict(node7, new BasicNode[] { node9 });
            currentMediator.setDict(node8, new BasicNode[] { node10 });
            currentMediator.setDict(node9, new BasicNode[] { node11 });
            currentMediator.setDict(node10, new BasicNode[] { node11 });
            currentMediator.setDict(node11, new BasicNode[] { s });

            cin.SetValue(true);
            a.SetValue(false);
            b.SetValue(true);

            Assert.AreEqual(cout.outputValue, true);
            Assert.AreEqual(s.outputValue, false);
        }
    }
}
