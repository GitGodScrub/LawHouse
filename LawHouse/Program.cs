using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (args.Length != 0)
            {
                switch (args[0])
                {
                    case "Ny GUI":
                        Application.Run(new Startside());
                        break;
                    case "Gammel GUI":
                        Application.Run(new New_case());
                        break;
                    case "":
                        DefaultRun();
                        break;
                }
                //command argument [0] er det første ord, efter kommandoen, før mellemrum nr 2
                //sæt evt alle mulighederne som værende muligheder specificeret i app.config
            }
            else
            {
                DefaultRun();
            }
        }

        static void DefaultRun()
        {
            Application.Run(new Startside());//sæt til at køre via en app.config specificeret fil i stedet for
        }
    }
}
