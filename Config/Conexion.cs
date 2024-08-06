using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//mysql
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace _03_MVC.Config
{
    class Conexion
    {
        private string cn;
        private MySqlConnection connection;
        private SqlConnection connection2;

        private string server = "localhost";
        private string database = "Cuarto";
        private string uid = "root";
        private string pwd = "root";

        public string ConexionBaseDatos() {

            // Server     Database   user id   password
            // server   database    uid    pwd
             return  cn = "Server=localhost;database=Cuarto;User Id=root;Password=root";
           
        }
        public void AbrirConexion() {

            try
            {
                ConexionBaseDatos();
                connection = new MySqlConnection("Server=localhost;database=Cuarto;User Id=root;Password=root");
                connection.Open();
                //connection2 = new SqlConnection(cn);
               // connection2.Open();
                Console.WriteLine("Se conecto con exito");

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error al abrir la conexion: " + ex.Message);
            }
        }
        public void CerrarConexion()
        {
            try
            {
                connection.Close();
                Console.WriteLine("Se cerro con exito");
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error al cerrar la conexion: " + ex.Message);
            }
        }

        public MySqlConnection ObtenerConexion() {

            return connection;
        }
    }
}
