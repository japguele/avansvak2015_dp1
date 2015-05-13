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

            Output output = (Output)CircuitFactory.CreateNode("OUTPUT");
            Input a = (Input)CircuitFactory.CreateNode("INPUT");
            Input b = (Input)CircuitFactory.CreateNode("INPUT");
            And and = (And)CircuitFactory.CreateNode("AND");



            a.AddNext(and);
            b.AddNext(and);

            and.AddNext(output);

            a.SetInput(true);
            b.SetInput(true);
            a.SendInput();
            b.SendInput();
            Console.WriteLine("test");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
      

        }
    }
}
