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
            Output output = new Output();
            Input a = new Input();
            Input b = new Input();  
            And and = new And();

            a.AddNext(and);
            b.AddNext(and);

            and.AddNext(output);

            a.setInput(true);
            b.setInput(true);
            a.SendInput();
            b.SendInput();
            Console.WriteLine("test");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
      

        }
    }
}
