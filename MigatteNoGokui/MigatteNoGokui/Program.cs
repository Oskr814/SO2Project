using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MigatteNoGokui
{
    static class Program
    {
        
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string carpeta = @"C:\logs_usuario";
            try
            {
                if (!Directory.Exists(carpeta));
                {
                    Directory.CreateDirectory(carpeta);
                }
            }
            catch (Exception e)
            {

            }



            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MigatteNoGokui());
        }
    }
}
