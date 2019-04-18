using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Management;
using System.IO;

namespace MigatteNoGokui
{
    class So2
    {
        /*Metodo para la ejecucion de comandos windows.
         * cmd oculto.
        */
        public Boolean ejecutarComando(string comando)
        {
            try
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    CreateNoWindow = true,
                    RedirectStandardInput = true,
                    RedirectStandardOutput = false,
                    UseShellExecute = false,
                    WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal


                };
                process.StartInfo = startInfo;
                process.Start();
                process.StandardInput.WriteLine(comando);
                process.StandardInput.Flush();
                process.StandardInput.Close();
                process.WaitForExit();
                if( comando =="bcdedit /set numproc 2" && getEstadoEjecucion() == 0)
                {
                    string path = "registro.mng";
                    string registro = "estado,1";
                    setEstadoEjecucion(path, registro);
                }
                
                return true;

            }
            catch (Exception e)
            {
                return false;
            }
        }
        
        /*Paso 1: validar numero de cores y establecer nucleos: 2 
          si cores > 2; Para paso 2 ver So2.ejecutarComando()
        */
        public void validarEjecucion()
        {
            string path = "registro.mng";
            string registro = "estado,0";
            FileStream fs;
            if (!File.Exists(path))
            {
                fs = new FileStream(path, FileMode.Create);
                setEstadoEjecucion(path, registro);
                fs.Close();
                Console.WriteLine("Exito!");
            }
            else
            {
                if(Convert.ToInt32(getProcessorInfo()[1]) > 2)
                {
                    if (getEstadoEjecucion() == 0)
                    {
                        ejecutarComando("bcdedit");

                    }
                }
            }
            
        }
        //Metodo para obtener logs
        public Boolean obtenerDatos()
        {
            return true;
        }

        public Boolean formatearDatos()
        {
            return true;
        }

        //Metodo para enviar informacion formateada a base de datos.
        public Boolean enviarDatos()
        {
            return true;
        }

        public void setEstadoEjecucion(string path, string registro)
        {
            FileStream fs;
            if (File.Exists(path))
            {
                fs = new FileStream(path, FileMode.Truncate);
                fs.Write(ASCIIEncoding.ASCII.GetBytes(registro), 0, registro.Length);
                fs.Close();
            }

        }

        public int getEstadoEjecucion()
        {
            byte[] lectura = new byte[8];
            string estado;
            string path = "registro.mng";
            if (File.Exists(path))
            {
                FileStream fs = new FileStream(path, FileMode.Open);
                fs.Read(lectura, 0, 8);
                fs.Close();
                estado = ASCIIEncoding.ASCII.GetString(lectura).Substring(7);
                return Convert.ToInt32(estado);
            }

            return 0;
        }

        
        public string[] getProcessorInfo()
        {
            string[] cpuInfo = new string[4];

            ManagementObjectSearcher query = new ManagementObjectSearcher(
                       "select * from Win32_Processor"
                );


            foreach (ManagementObject info in query.Get())
            {
                foreach (PropertyData propiedad in info.Properties)
                {

                    if (propiedad.Name == "Name")
                    {
                        cpuInfo[0] = propiedad.Value.ToString();
                    }

                    if (propiedad.Name == "NumberOfLogicalProcessors")
                    {
                        cpuInfo[1] = propiedad.Value.ToString();
                    }

                    if (propiedad.Name == "MaxClockSpeed")
                    {
                        cpuInfo[2] = (Convert.ToInt32(propiedad.Value) / 1024).ToString() + "GHZ";
                    }

                    if (propiedad.Name == "CurrentVoltage")
                    {
                        cpuInfo[3] = propiedad.Value.ToString() + "v";
                    }
                }
            }

            return cpuInfo;
        }

        public int getRamVal()
        {

            ManagementObjectSearcher ramInfo = new ManagementObjectSearcher(
                       "SELECT * FROM Win32_OperatingSystem"
                );
            ManagementObjectCollection results = ramInfo.Get();



            foreach (ManagementObject result in results)
            {
                return Convert.ToInt32(result["TotalVisibleMemorySize"]) / 1024;
            }

            return 0;

        }
    }
}
