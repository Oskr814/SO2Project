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

                /*process.StandardInput.Flush();
                process.StandardInput.WriteLine("shutdown /r /t 10");*/

                process.StandardInput.Flush();
                process.StandardInput.Close();
                process.WaitForExit();
                if( getEstadoEjecucion() == 0)
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

        public int getNumberOfCores()
        {
            int numeroCores = 0;

            ManagementObjectSearcher query = new ManagementObjectSearcher(
                       "select * from Win32_Processor"
                );


            foreach (ManagementObject info in query.Get())
            {
                foreach (PropertyData propiedad in info.Properties)
                {
                    if (propiedad.Name == "NumberOfCores")
                    {
                        numeroCores = Convert.ToInt32(propiedad.Value);
                    }
                }
            }

            return numeroCores;
        }

        public int getRamVal()
        {
            
            ManagementObjectSearcher ramInfo = new ManagementObjectSearcher(
                       "SELECT * FROM Win32_OperatingSystem"
                );
            ManagementObjectCollection results = ramInfo.Get();


            
            foreach (ManagementObject result in results)
            {
                return Convert.ToInt32(result["TotalVisibleMemorySize"]);
            }

            return 0;
            
        }



        public Boolean ejecutarArchivo(string nombre)
        {
            return true;
        }

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
                if (getEstadoEjecucion() == 0)
                {
                    ejecutarComando("bcdedit");

                }
            }
            
        }

        public Boolean obtenerDatos()
        {
            return true;
        }

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

        public int getCpuState()
        {
            PerformanceCounter cpu = new PerformanceCounter();
            cpu.CategoryName = "Processor";
            cpu.CounterName = "% Processor Time";
            cpu.InstanceName = "_Total";
            return Convert.ToInt32(cpu.NextValue());
            
            
        }
    }
}
