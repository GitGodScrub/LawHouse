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
            //command argument [0] er det første ord, efter kommandoen, før mellemrum nr 2
            //sæt evt alle mulighederne som værende muligheder specificeret i app.config
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (args.Length != 0)
            {
                switch (args[0])
                {
                    case "Ny GUI":
                        Application.Run(new ExperimentalForm());
                        break;
                    case "Gammel GUI":
                        //Application.Run(new New_case());
                        break;
                    case "":
                        DefaultRun();
                        break;
                }
                
            }
            else
            {
                DefaultRun();
            }
        }

        static void DefaultRun()//sæt til at køre via en app.config specificeret fil i stedet for
        {
            Application.Run(new ExperimentalForm());
        }
    }
}
