using CircuitSimulater.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace CircuitSimulater
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            And.Register();
            Input.Register();
            Not.Register();
            Or.Register();
            Output.Register();

            BasicNode output = CircuitFactory.CreateNode("OUTPUT");
            BasicNode a = CircuitFactory.CreateNode("INPUT");
            BasicNode b = CircuitFactory.CreateNode("INPUT");
            BasicNode and = CircuitFactory.CreateNode("AND");

            a.AddNext(and); // zet de next node die de waarde van de uitkomst van deze node moet krijgen
            b.AddNext(and); // zet de next node die de waarde van de uitkomst van deze node moet krijgen
            and.AddNext(output); // zet de next node die de waarde van de uitkomst van deze node moet krijgen


            a.SendValueToNext(true);//dit bij de inputs
            b.SendValueToNext(true);//dit bij de inputs
            Console.WriteLine("test");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
      

        }
    }
}
