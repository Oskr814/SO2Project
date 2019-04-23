using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

namespace MigatteNoGokui
{
    class ComandosCmd
    {
        static string direccion = Application.StartupPath.ToString() + @"\logs_usuario\ejecucion.bat";
        // static string direccion1 = Application.StartupPath.ToString() + @"\text.txt";
        string commandChrome = "tasklist /V /FI \"imagename eq chrome.exe\" /FO csv > " + @"logs_usuario\logsChrome.txt";
        string commandIExplore = "tasklist /V /FI \"imagename eq iexplore.exe\" /FO csv > " + @"logs_usuario\logsIExplore.txt";
        string commandFirefox = "tasklist /V /FI \"imagename eq firefox.exe\" /FO csv > " + @"logs_usuario\logsFirefox.txt";

        Process cmdProcess = new Process();

        public ComandosCmd ()
        {
            string path = direccion;
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(commandChrome);
                    sw.WriteLine(commandIExplore);
                    sw.WriteLine(commandFirefox);
                }
            }
        }

        public void EjecutarComando ()
        {
            try
            {
                Process.Start(direccion);

            }
            catch (Exception e)
            {
                Console.WriteLine("No se pudo lograr el asunto");
            }

        }
          
    }

}
