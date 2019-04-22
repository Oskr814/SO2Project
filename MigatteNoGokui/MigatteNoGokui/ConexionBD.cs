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


namespace MigatteNoGokui
{
    class ConexionBD
    {
        SqlCommand comando;

        // Conexión con la base de datos se hace desde aquí, si se desea cambiar la base de datos, hacerlo en data Source
        string cadenaConexion = "Data Source=2DESKTOP-RQDTPHQ; Initial Catalog=SO2_LOGS; Integrated Security=True;";
        public SqlConnection conectarBase = new SqlConnection();
        string consulta = "SELECT * FROM USUARIOS where Nombre_Usuario = '" + Environment.UserName.ToString() + "';";
        int id = 0;
        SqlDataReader lectura;


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

                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Consulta NO POSIBLE  " + e.Message);
                    

                }
            }
            catch
            {
                Console.WriteLine("conexion sin éxito");
                // si no hay conexión se deberá llamar a un archivo .txt para almacenarlos
                this.EnviarCorreo();
            }


        }

        public void InsertRegistro()
        {

            // LLamado al documento que contiene los LOGS del usuario en la pag web
            Thread.Sleep(50);
            string[] lineas = File.ReadAllLines("./logs_usuario/logs.txt");
            string nombreVentana;

            Regex reg = new Regex("[^a-zA-Z0-9 ]");
            if (lineas.Length > 2)
            {
                var valores = lineas[1].Split(',');
                var nombreVentanas = valores[8].Split('-');
                if ( nombreVentanas.Length > 2)
                {
                    nombreVentana = nombreVentanas[nombreVentanas.Length - 2].Normalize(NormalizationForm.FormD); 
                }
                else
                {
                    // se quitan las letras que no estén en ASCII
                    nombreVentana = nombreVentanas[0].Remove(0, 1).Normalize(NormalizationForm.FormD);
                    
                }
 
                var tiempoCPU = valores[7].Remove(0, 1);
                tiempoCPU = tiempoCPU.Remove(tiempoCPU.Length - 1);

                Console.WriteLine("Tiempo de CPU: " + tiempoCPU + "--   Nombre de ventana: " + reg.Replace(nombreVentana, ""));

                try
                {
                    // cerrando cualquier conexion antes hecha
                    conectarBase.Close();

                    // abriendo la conexion para ejecutar comando
                    conectarBase.Open();
                    comando = new SqlCommand(" INSERT INTO HISTORIAL VALUES ( " + Environment.UserName.ToString() + ", '" + reg.Replace(nombreVentana, "") + "', '" + tiempoCPU + "', GETDATE() ); ", conectarBase);
                    comando.ExecuteNonQuery();
                    Console.WriteLine("Nuevo registro agregado");
                }
                catch (Exception e)
                {

                    Console.WriteLine("no se pudo agregar registro a historial");
                    // Console.WriteLine(e.ToString());

                    string path = Application.StartupPath.ToString() + @"\Backup_noConection.txt";
                    if (!File.Exists(path))
                    {
                        // Create a file to write to.
                        using (StreamWriter sw = File.CreateText(path))
                        {
                            sw.WriteLine(Environment.UserName.ToString() + "," + reg.Replace(nombreVentana, "") + "," + tiempoCPU + "," + DateTime.Now.ToString());
                            sw.Close();
                            Console.WriteLine("se creó el erchivo");
                        }
                    }
                    else
                    {
                        using (StreamWriter sw = File.AppendText(path))
                        {
                            sw.WriteLine(id + "," + reg.Replace(nombreVentana, "") + "," + tiempoCPU + "," + DateTime.Now.ToString());
                            sw.Close();
                            Console.WriteLine("se agregó información al archivo");
                        }
                    }

                }
            }

    
        }

        public void Cerrar()
        {
            conectarBase.Close();
            Console.WriteLine("conexion cerrada");
        }

        public void EnviarCorreo()
        {


            string file = Path.GetFileName(Application.StartupPath.ToString() + @"\logs_usuario\Backup_noConection.txt");
            using (SmtpClient cliente = new SmtpClient("smtp.gmail.com", 587))
            {
                cliente.EnableSsl = true;
                cliente.Credentials = new NetworkCredential("proyectoso2unah@gmail.com", "asd.123456");
                MailMessage mensaje = new MailMessage("proyectoso2unah@gmail.com", "proyectoso2unah@gmail.com", "Informe de navegación", "estoy socando por pasar esta clase");
                mensaje.Attachments.Add( new Attachment(file) );
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
    }
}
