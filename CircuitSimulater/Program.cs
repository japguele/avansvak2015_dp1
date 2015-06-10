using CircuitSimulator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircuitSimulator
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
            Xor.Register();
            Nand.Register();
            Nor.Register();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }
    }
}
