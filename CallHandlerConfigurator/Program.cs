using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CallHandlerConfigurator
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                try
                {
                    new CallHandler(args[0]).Start();
                }catch(Exception ex)
                {
                    MessageBox.Show("Houve um problema: " + ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FormMain());
            }
        }
    }
}
