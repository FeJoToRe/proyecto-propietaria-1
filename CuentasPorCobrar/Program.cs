using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuentasPorCobrar
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Login = new FrmLogin();
            Application.Run(Login);
        }
        public static FrmLogin Login { get; set; }
        public static USUARIOS usuario { get; set; }
    }
}
