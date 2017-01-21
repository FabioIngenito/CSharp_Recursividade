using System;
using System.Windows.Forms;

namespace waRecursividade
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// 
        /// O ponto de entrada principal para a aplicação.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmRecursividade());
        }
    }
}
