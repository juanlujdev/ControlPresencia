#region Usings
using Renci.SshNet.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.CodeDom;
using System.Text.RegularExpressions;
#endregion

namespace ControlDePresencia
{   /// <summary>
    ///Libreria de Metodos estaticos para comprobacines recurrentes, y consultas 
    ///especificas a la base de datos para cargar DataGreedView
    /// </summary>
    static class LibreriaMetodos
    {
        #region Metodo Estaticos de Comprobación
        /// <summary>
        /// Comprueba si la letra del dni pasado como parametro es correcta
        /// </summary>
        /// <param name="nif"></param>
        /// <returns>Devuelve tipo bool</returns>
        static public bool ComprobarLetra(string nif)
        {
            bool ok = true;
            try
            {
                string tabla = "TRWAGMYFPDXBNJZSQVHLCKET";
                int indice;
                string soloNumeros = nif.Substring(0, nif.Length - 1);//obtiene solo la numeracion del nif pasado por parametro
                int numeros = Convert.ToInt32(soloNumeros);
                indice = numeros % 23; //Calculo para sacar la poscion de la letra a raiz del numero del dno

                char letraCalculada = tabla[indice]; //letra que obtiene del calculo
                char letraParametro = nif[8]; //Letra del nif pasado por parametro
                ok = letraCalculada == letraParametro ? true : false;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Valores incorrectos");
            }
            return ok;
        }
        /// <summary>
        /// Comprueba que los 8 primeros valores del dni solo sean numericos
        /// </summary>
        /// <param name="nif"></param>
        /// <returns>devuelve bool</returns>
        static public bool ComprobarCadaValorNif(string nif)
        {
            string soloNumeros = nif.Substring(0, nif.Length - 1);
            bool esString= false;
            for (int i = 0; i < soloNumeros.Length; i++)
            {             
                if (Char.IsLetter(soloNumeros, i)) esString = true;              
            }
            return esString;
        }

        /// <summary>
        /// Comprueba si el empleado existe a raiz de un nif pasado como parametro
        /// </summary>
        /// <param name="nif"></param>
        /// <param name="conexion"></param>
        /// <returns>Devuelve tipo bool</returns>
        static public bool ComprobarEmpleado(string nif, MySqlConnection conexion)
        {
            bool exist = false;
            string consulta = String.Format("SELECT * FROM empleado WHERE nif = '{0}' and alta=true;", nif); //Query
            MySqlCommand comando = new MySqlCommand(consulta, conexion); //Se instancia la clase command para la consulta
            //MessageBox.Show(consulta); //Comprobacion
            MySqlDataReader reader = comando.ExecuteReader(); //Lanza la consulta
            exist = reader.HasRows ? true : false; //Almacenara F/T dependiendo si encuentra o no coincidencia
            reader.Close();
            return exist;
        }

        /// <summary>
        /// Comprueba si el empleado a fichado a raiz de un nif pasado como parametro
        /// </summary>
        /// <param name="nif"></param>
        /// <param name="conexion"></param>
        /// <returns>Devuelve tipo bool</returns>
        static public bool ComprobarFichaje(string nif, MySqlConnection conexion)
        {
            bool exist = false; 
            string consulta = String.Format("SELECT * FROM fichaje WHERE nif = '{0}' AND finalizar = false;", nif); //Query
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            //MessageBox.Show(consulta); //Comprobacion
            MySqlDataReader reader = comando.ExecuteReader(); 
            exist = reader.HasRows ? true : false;
            reader.Close();
            return exist;
        }

        /// <summary>
        /// Comprueba si el empleado es administrador por el nif
        /// </summary>
        /// <param name="nif"></param>
        /// <param name="conexion"></param>
        /// <returns>Devuelve tipo bool</returns>
        static public bool ComprobarAdmin(string nif, MySqlConnection conexion)
        {
            bool isadmin = false; 
            string consulta = String.Format("SELECT * FROM empleado WHERE administrador = TRUE AND nif = '{0}';",nif); //Query
            MySqlCommand comando = new MySqlCommand(consulta, conexion); 
            //MessageBox.Show(consulta); //Comprobacion
            MySqlDataReader reader = comando.ExecuteReader(); 
            isadmin = reader.HasRows ? true : false;
            reader.Close();
            return isadmin;
        }

        /// <summary>
        /// Contrasta el password pasado por parametro contra el de la base datos.
        /// </summary>
        /// <param name="password"></param>
        /// <param name="conexion"></param>
        /// <returns></returns>
        static public bool ComprobarPassword(string password, MySqlConnection conexion)
        {
            bool exist = false;
            string consulta = String.Format("SELECT * FROM empleado WHERE administrador = true AND contraseña like '{0}';" ,password); //Query
            MySqlCommand comando = new MySqlCommand(consulta, conexion); 
            //MessageBox.Show(consulta); //Comprobacion
            MySqlDataReader reader = comando.ExecuteReader(); 
            exist = reader.HasRows ? true : false; 
            reader.Close();
            return exist;
        }
        #endregion

        #region Metodo Estaticos de consultas para los DataGreedView
        /// <summary>
        /// Obtiene, nombre,apellido y hora de entrada de los empleados que tiene el fichaje abierto.
        /// </summary>
        /// <param name="conexion"></param>
        /// <returns> Devuevle un objeto de tipo BindinSource</returns>
        static public BindingSource MostrarEmpleado(MySqlConnection conexion)
        {
            BindingSource bs = new BindingSource(); ///QUE ES EXACTAMENTE?¿?¿?¿
            string consulta = "SELECT nombre, apellidos,horaEntrada FROM empleado INNER JOIN fichaje ON empleado.nif=fichaje.nif WHERE finalizar=FALSE";
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            //MessageBox.Show(consulta);//Comprobacion
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                bs.DataSource = reader;
                reader.Close();
            }
            else
            {
                MessageBox.Show("No se han obtenido resultados que visualizar de empleados");
            }
            return bs;
        }
        /// <summary>
        /// Obtiene los datos de un empleado concreto a partir de un niz
        /// </summary>
        /// <param name="conexion"></param>
        /// <param name="nif"></param>
        /// <returns>Devuevle un objeto de tipo BindinSource</returns>
        static public BindingSource MostrarEmpleado(MySqlConnection conexion,string nif)
        {
            BindingSource bs = new BindingSource();
            string consulta = String.Format("SELECT * FROM empleado WHERE nif = '{0}';",nif);
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            //MessageBox.Show(consulta);//Comprobacion
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                bs.DataSource = reader;
                reader.Close();
            }
            else
            {
                MessageBox.Show("No se han obtenido resultados que visualizar de empleados");
            }
            return bs;
        }
        /// <summary>
        /// Obtiene toda la informacion de la tabla empelado
        /// </summary>
        /// <param name="conexion"></param>
        /// <returns>Devuevle un objeto de tipo BindinSource</returns>
        static public BindingSource MostrarTodoEmpleado(MySqlConnection conexion)
        {
            BindingSource bs = new BindingSource();
            string consulta = "SELECT * FROM empleado;";
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            //MessageBox.Show(consulta);//Comprobacion
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                bs.DataSource = reader;
                reader.Close();
            }
            else
            {
                MessageBox.Show("No se han obtenido resultados que visualizar de empleados");
            }
            return bs;
        }
        /// <summary>
        /// Obtiene, hora de entrada, salida y tiempo transcurrido entre estas de un empleado a partir de un nif
        /// </summary>
        /// <param name="fecha1"></param>
        /// <param name="fecha2"></param>
        /// <param name="conexion"></param>
        /// <param name="nif"></param>
        /// <returns>Devuevle un objeto de tipo BindinSource</returns>
        static public BindingSource MostrarFichaje(DateTime fecha1, DateTime fecha2, MySqlConnection conexion, string nif)
        {
            BindingSource bs = new BindingSource();
            string consulta = String.Format("SELECT horaEntrada, horaSalida, TIMESTAMPDIFF (MINUTE, horaEntrada, horaSalida) AS Duracion_Minutos " +
                "from fichaje WHERE finalizar=true AND nif ='{2}' " +
                "AND horaSalida BETWEEN '{0}' AND '{1}';", fecha1.ToString("yyyy-MM-dd 00:00:00"), fecha2.ToString("yyyy-MM-dd 23:59:59"), nif);
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            //MessageBox.Show(consulta);//Comprobacion
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                bs.DataSource = reader;
                reader.Close();
            }
            else
            {
                MessageBox.Show("No se han obtenido resultados que visualizar de fichajes");
            }
            return bs;
        }

        /// <summary>
        /// Obtiene todos los datos de la tabla Fichaje
        /// </summary>
        /// <param name="conexion"></param>
        /// <returns>Devuevle un objeto de tipo BindinSource</returns>
        static public BindingSource MostrarFichaje(MySqlConnection conexion)
        {
            BindingSource bs = new BindingSource();
            string consulta = String.Format("SELECT * FROM fichaje;");
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            //MessageBox.Show(consulta);//Comprobacion
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                bs.DataSource = reader;
                reader.Close();
            }
            else
            {
                MessageBox.Show("No se han obtenido resultados que visualizar de fichajes");
            }
            return bs;
        }

        /// <summary>
        /// Obtiene los datos de un empleado concreto a partir de un nif 
        /// </summary>
        /// <param name="conexion"></param>
        /// <param name="nif"></param>
        /// <returns>Devuevle un objeto de tipo BindinSource</returns>
        static public BindingSource MostrarFichaje(MySqlConnection conexion, string nif)
        {
            BindingSource bs = new BindingSource();
            string consulta = String.Format("SELECT * FROM fichaje where nif='{0}';",nif);
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            //MessageBox.Show(consulta);//Comprobacion
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                bs.DataSource = reader;
                reader.Close();
            }
            else
            {
                MessageBox.Show("No se han obtenido resultados que visualizar de fichajes");
            }
            return bs;
        }
        #endregion
    }
}
