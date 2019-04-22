using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;
using System.IO;

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
            }


        }

        public void InsertRegistro()
        {
            if (true) //No habia nada en el if
            {
                // LLamado al documento que contiene los LOGS del usuario en la pag web
                string[] lineas = File.ReadAllLines("./logs_usuario/logs.txt");
                var valores = lineas[1].Split(',');
                var nombreVentana = valores[8].Split('-');

                var tiempoCPU = valores[7].Remove(0, 1);
                tiempoCPU = tiempoCPU.Remove(tiempoCPU.Length - 1);

                Console.WriteLine("Tiempo de CPU: " + tiempoCPU + "--   Nombre de ventana: " + nombreVentana[0].Remove(0, 1));

                try
                {
                    // cerrando cualquier conexion antes hecha
                    conectarBase.Close();

                    // abriendo la conexion para ejecutar comando
                    conectarBase.Open();
                    comando = new SqlCommand(" INSERT INTO HISTORIAL VALUES ( " + id + ", '" + nombreVentana[0].Remove(0, 1) + "', '" + tiempoCPU + "', GETDATE() ); ", conectarBase);
                    comando.ExecuteNonQuery();
                    Console.WriteLine("Nuevo registro agregado");
                }
                catch (Exception e)
                {
                    Console.WriteLine("no se pudo agregar registro a historial");
                    Console.WriteLine(e.ToString());
                }
            }
    
        }

        public void Cerrar()
        {
            conectarBase.Close();
            Console.WriteLine("conexion cerrada");
        }
    }
}
