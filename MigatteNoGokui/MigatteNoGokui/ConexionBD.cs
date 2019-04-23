using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using System.Collections;


namespace MigatteNoGokui
{
    class ConexionBD
    {
        SqlCommand comando;

        // Conexión con la base de datos se hace desde aquí, si se desea cambiar la base de datos, hacerlo en data Source
        string cadenaConexion = "Data Source=DESKTOP-RQDTPHQ; Initial Catalog=SO2_LOGS; Integrated Security=True;";
        public SqlConnection conectarBase = new SqlConnection();
        string consulta = "SELECT * FROM USUARIOS where Nombre_Usuario = '" + Environment.UserName.ToString() + "';";
        int id = 0;
        SqlDataReader lectura;
        Boolean conexion = false;
        string logsChrome = "./logs_usuario/logsChrome.txt";
        string logsIExplore = "./logs_usuario/logsIExplore.txt";
        string logsFirefox = "./logs_usuario/logsFirefox.txt";
        string chrome = "Chrome";
        string explorer = "IExplore";
        string firefox = "Firefox";

        public ConexionBD()
        {
            try
            {
                conectarBase.ConnectionString = cadenaConexion;
                conectarBase.Open();
                Console.WriteLine("conexion éxitosa");
                try
                {
                    comando = new SqlCommand(consulta, conectarBase);
                    lectura = comando.ExecuteReader();
                    if (lectura.Read())
                    {
                        // recuperar el ID para hacer las inserciones
                        id = Convert.ToInt32(lectura["usuarioID"]);
                        Console.WriteLine("Usuario en la base, ID: " + id);
                    }
                    else
                    {
                        conectarBase.Close();
                        // nueva conexion para hacer una nueva consulta
                        conectarBase.Open();
                        comando = new SqlCommand(" INSERT INTO USUARIOS VALUES ( '" + Environment.UserName + "' ) ", conectarBase);
                        comando.ExecuteNonQuery();
                        Console.WriteLine("Nuevo usuario agregado");

                        conectarBase.Close();
                        // recuperar el id del registro recién ingresado
                        conectarBase.Open();
                        comando = new SqlCommand(consulta, conectarBase);
                        lectura = comando.ExecuteReader();
                        if (lectura.Read())
                        {
                            id = Convert.ToInt32(lectura["usuarioID"]);
                            Console.WriteLine("Usuario en la base, ID: " + id);
                        }
                        // conexion = true;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Consulta NO POSIBLE  " + e.Message);
                    conexion = false;

                }
            }
            catch
            {
                Console.WriteLine("conexion sin éxito");
                // si no hay conexión se deberá llamar a un archivo .txt para almacenarlos
                // this.EnviarCorreo();
                try
                {

                    ArrayList datosChrome = RecuperacionDatos(logsChrome);
                    ArrayList datosIExplore = RecuperacionDatos(logsIExplore);
                    ArrayList datosFirefox = RecuperacionDatos(logsFirefox);

                    this.BackupTxt(datosChrome, chrome);
                    this.BackupTxt(datosIExplore, explorer);
                    this.BackupTxt(datosFirefox, firefox);
                }
                catch (Exception e)
                {
                    Console.WriteLine("No se pudo hacer backup");
                }

                this.EnviarCorreo();
            }

        }

        public void InsertRegistro()
        {
            ArrayList datosChrome = RecuperacionDatos(logsChrome);
            ArrayList datosIExplore = RecuperacionDatos(logsIExplore);
            ArrayList datosFirefox = RecuperacionDatos(logsFirefox);

            try
            {
                InsertaRegistros(datosChrome, chrome);
                InsertaRegistros(datosIExplore, explorer);
                InsertaRegistros(datosFirefox, firefox);
            }
            catch (Exception e)
            {
                Console.WriteLine("no se pudo agregar registro a historial");

            }
            

    
        }

        public void Cerrar()
        {
            conectarBase.Close();
            Console.WriteLine("conexion cerrada");
        }

        public void EnviarCorreo()
        {


            string fileChrome = Path.GetFileName(Application.StartupPath.ToString() + @"\logs_usuario\Backup_noConection" + chrome +".txt");
            string fileIExplore = Path.GetFileName(Application.StartupPath.ToString() + @"\logs_usuario\Backup_noConection" + explorer + ".txt");
            string fileFirefox = Path.GetFileName(Application.StartupPath.ToString() + @"\logs_usuario\Backup_noConection" + firefox + ".txt");
            using (SmtpClient cliente = new SmtpClient("smtp.gmail.com", 587))
            {
                cliente.EnableSsl = true;
                cliente.Credentials = new NetworkCredential("proyectoso2unah@gmail.com", "asd.123456");
                MailMessage mensaje = new MailMessage("proyectoso2unah@gmail.com", "proyectoso2unah@gmail.com", "Informe de navegación", "estoy socando por pasar esta clase");
                mensaje.Attachments.Add( new Attachment(fileChrome) );
                mensaje.Attachments.Add(new Attachment(fileIExplore));
                mensaje.Attachments.Add(new Attachment(fileFirefox));
                try
                {
                    cliente.Send(mensaje);
                    Console.Write("correo enviado");
                }
                catch (Exception e)
                {
                    Console.WriteLine("hubo un problema");
                    Console.WriteLine(e.ToString());

                }
            }
        }

        public void BackupTxt(ArrayList info, string navegador)
        {
            string path = Application.StartupPath.ToString() + @"\Backup_noConection" + navegador + ".txt";
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path));
            }

            foreach (var registro in info)
            {
                var valor = registro.ToString().Split(',');
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(Environment.UserName + "," + valor[0] + "," + valor[1] + "," + DateTime.Now.ToString());
                    sw.Close();
                    Console.WriteLine("se agregó información al archivo");
                }

            }
            
        }

        private ArrayList RecuperacionDatos(string direccion)
        {
            // LLamado al documento que contiene los LOGS del usuario en la pag web
            string[] lineas = File.ReadAllLines(direccion);
            string nombreVentana;
            Regex reg = new Regex("[^a-zA-Z0-9 ]");
            ArrayList retorno = new ArrayList();

            foreach (var linea in lineas)
            {
                var valor = linea.Split(',');
                // Filtro de los valore que no nos interesan recuperar
                if ((valor.Length == 9) && (reg.Replace(valor[8], "") != "Ttulo de ventana"))
                {
                    //Console.WriteLine(valor[8]);
                    if ((valor[8].ToString() != "\"N/D\""))
                    {
                        //Console.WriteLine(reg.Replace(valor[8], ""));
                        var nombreVentanas = valor[8].Split('-');
                        if (nombreVentanas.Length > 2)
                        {
                            nombreVentana = nombreVentanas[nombreVentanas.Length - 2].Normalize(NormalizationForm.FormD);
                        }
                        else
                        {
                            // se quitan las letras que no estén en ASCII
                            nombreVentana = nombreVentanas[0].Remove(0, 1).Normalize(NormalizationForm.FormD);

                        }

                        var tiempoCPU = valor[7].Remove(0, 1);
                        tiempoCPU = tiempoCPU.Remove(tiempoCPU.Length - 1);

                        Console.WriteLine("Recuperación de datos\n"+"Nombre Ventana: "+ reg.Replace(nombreVentana, "") + "\nTiempoCPU: "+ tiempoCPU);

                        retorno.Add(reg.Replace(nombreVentana, "") + "," + tiempoCPU);
                    }

                }

            }
            return retorno;
        }

        private void InsertaRegistros (ArrayList arreglo , string navegador)
        {
            foreach ( var registro in arreglo )
            {
                try
                {
                    var valor = registro.ToString().Split(',');

                    // cerrando cualquier conexion antes hecha
                    conectarBase.Close();

                    // abriendo la conexion para ejecutar comando
                    conectarBase.Open();
                    comando = new SqlCommand(" INSERT INTO HISTORIAL VALUES ( " + this.id + ", '" + valor[0] + "', '" + valor[1] + "', GETDATE() ); ", conectarBase);
                    comando.ExecuteNonQuery();
                    Console.WriteLine("Nuevo registro agregado: " + valor[0] + "   " + valor[1]);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("NO SE PUDO HACER INSERCIÓN");
                    this.BackupTxt( arreglo, navegador );
                }
            }
        }
    }
}
