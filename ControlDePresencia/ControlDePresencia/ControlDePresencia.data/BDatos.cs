#region Usings
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#endregion

namespace ControlDePresencia
{
    /// <summary>
    /// Clase estatica que se encarga de las conxiones a la base de datos
    /// </summary>
    static class BDatos
    {
        //atributo estatico de la conexion
        private static MySqlConnection conexion;

        #region Metodos que manejan la conexion a la base de datos
        /// <summary>
        /// Instancia un objeto de tipo MySqlConnection y se le pasa el string con la configuracion 
        /// de la conexion
        /// </summary>
        /// <returns>Devuelve el objeto de tuipo MysQlConnection</returns>
        public static MySqlConnection ConexionBD()
        {
            //Conexión Local
            string server = "server=127.0.0.1;";
            string port = "port=3306;";
            string database = "database=control_presencia;";
            string usuario = "uid=root;";
            string password = "pwd=;";
            string datetime = "Convert Zero Datetime = True";
            string connectionstring = server + port + database + usuario + password + datetime;

            conexion = new MySqlConnection(connectionstring);
            return conexion;
        }

        /// <summary>
        ///Método que se encarga de abrir la conexión
        /// </summary>
        /// <returns>Devuelve true/false dependiendo si la conexión se ha abierto con éxito o no</returns>
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
        /// <summary>
        /// Método que se encarga de cerrar la conexión (evitar dejar conexiones abiertas)
        /// </summary>
        /// <returns>Devuelve true/false dependiendo si la conexión se ha cerrado con éxito</returns>
        public static bool CerrarConexion()
        {
            try
            {
                conexion.Close();
                //MessageBox.Show("Se cierra la conexion"); //Comprobacion
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        #endregion
    }
}

