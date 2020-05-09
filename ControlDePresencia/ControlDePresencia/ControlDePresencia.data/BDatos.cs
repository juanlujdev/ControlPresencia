using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlDePresencia
{
    static class BDatos
    {
        // atributo para gestionar la conexión
        private static MySqlConnection conexion;

        public static MySqlConnection ConexionBD()
        {
            //Conexión Local
            string server = "server=127.0.0.1;";
            string port = "port=3306;";
            string database = "database=BDUsuarios;";
            string usuario = "uid=root;";
            string password = "pwd=;";
            string datetime = "Convert Zero Datetime = True";
            string connectionstring = server + port + database + usuario + password + datetime;

            conexion = new MySqlConnection(connectionstring);
            return conexion;
        }

        // Método que se encarga de abrir la conexión
        // Devuelve true/false dependiendo si la conexión se ha abierto con éxito o no
        public static bool AbrirConexion()
        {
            try
            {
                conexion.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        // Método que se encarga de cerrar la conexión (evitar dejar conexiones abiertas)
        // Devuelve true/false dependiendo si la conexión se ha cerrado con éxito
        public static bool CerrarConexion()
        {
            try
            {
                conexion.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}

