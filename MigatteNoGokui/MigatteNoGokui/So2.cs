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
        /*Metodo para la ejecucion de comandos windows / Cmd oculto.*/
        public Boolean ejecutarComando(string comando)
        {
            try
            {
                //Creacion de nuevo proceso, el cual alojara el CMD
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    CreateNoWindow = true, //No mostrar ventana del CMD / oculto
                    RedirectStandardInput = true,
                    RedirectStandardOutput = false,
                    UseShellExecute = false,
                    WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal
                    
                };
                //Asignacion de directivas del proceso / Propiedades de que ejecutar
                process.StartInfo = startInfo;
                //Ejecutar proceso / CMD
                process.Start();
                //Establecer comando a ejecutar
                process.StandardInput.WriteLine(comando);
                //Vaciar comando en cmd para su ejecucion
                process.StandardInput.Flush();
                //Cerrar canal de comunicacion
                process.StandardInput.Close();
                process.WaitForExit();

                //Si el comando es para apagar los nucleos, establecer estado,1
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
        
        /*Metodo para validar la ejecucion, es decir, si ya se realizo el proceso
         * de apagar los nucleos.
         * Paso 1: validar numero de cores y establecer nucleos: 2 
          si cores > 2; Para paso 2 ver So2.ejecutarComando()
        */
        public void validarEjecucion()
        {
            string path = "registro.mng"; //registro.mng se encargara de registrar el estado de la ejecucion
            string registro = "estado,0";
            FileStream fs;
            //Verificar si no existe el archivo registro.mng para su creacion
            if (!File.Exists(path))
            {
                fs = new FileStream(path, FileMode.Create);
                setEstadoEjecucion(path, registro);
                fs.Close();
                Console.WriteLine("Exito!");
            }
            else //Si el archivo ya existe entonces se procede a verificar cuantos cores tiene el sistema
            {
                //Si el sistema tiene mas de dos cores entonces se dejan solo dos activos
                if(Convert.ToInt32(getProcessorInfo()[1]) > 2)
                {
                    //Ejecutar comando para apagar los nucelos
                    if (getEstadoEjecucion() == 0)
                    {
                        ejecutarComando("bcdedit"); //bcdedit /set numproc 2 

                    }
                }
            }
            
        }

        //Metodo para obtener logs
        public Boolean obtenerDatos()
        {
            return true;
        }

        //Metodo para formatear los logs 
        public Boolean formatearDatos()
        {
            return true;
        }

        //Metodo para enviar informacion formateada a base de datos.
        public Boolean enviarDatos()
        {
            return true;
        }

        //Metodo para escribir en el archivo registro.mng
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

        //Metodo para leer el archivo registro.mng y obtener el estado de ejecucion
        public int getEstadoEjecucion()
        {
            byte[] lectura = new byte[8]; //Cantidad exacta de caracteres.
            string estado;
            string path = "registro.mng";
            if (File.Exists(path))
            {
                FileStream fs = new FileStream(path, FileMode.Open);
                fs.Read(lectura, 0, 8); //(arreglo[], <linea_comienzo_lectura>, <cantidad_caracteres_lectura>)
                fs.Close(); //Cerrar canal de comunicacion
                //obtener caracter despues de la 7ma posicion del arreglo
                estado = ASCIIEncoding.ASCII.GetString(lectura).Substring(7); 
                return Convert.ToInt32(estado);
            }

            return 0;
        }
        
        //Metodo para obtener informacion del procesador
        public string[] getProcessorInfo()
        {
            //Arreglo para almacenar las propiedades seleccionadas: nombre, numerocores, frecuenca, voltaje
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

        //Metodo para obtener total Ram
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
