#region Usings
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#endregion
namespace ControlDePresencia.ControlDePresencia.biz
{
    class Empleado
    {
        #region Atributos
        private bool alta;
        private string nif;
        private string nombre;
        private string apellidos;
        private bool administrador;
        private string contraseña;
        #endregion

        #region Propiedades
        public bool Alta { get { return alta; } set { alta = value; } }
        public string Nif { get { return nif; } set { nif = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Apellidos { get { return apellidos; } set { apellidos = value; } }
        public bool Administrador { get { return administrador; } set { administrador = value; } }
        public string Contraseña { get { return contraseña; } set { contraseña = value; } }
        #endregion

        #region Constructores
        public Empleado()
        {

        }
        public Empleado(bool alt,string n,string no,string ap,bool ad,string ctr)
        {
            alta = alt;
            nif = n;
            nombre = no;
            apellidos = ap;
            administrador = ad;
            contraseña = ctr;
        }
        #endregion

        #region Metodos de interfaz
        /// <summary>
        /// Hace un update en la base de datos del atributo alta del empleado , pero no lo borra de la base de datos
        /// </summary>
        /// <param name="conexion"></param>
        /// <param name="nif"></param>
        /// <returns>Devuelve true o false si ha modificado linea en la base de datos</returns>
        public bool EliminarEmpleado(MySqlConnection conexion ,string nif)
        {
            int retorno;
            bool exist = false; //Almacenara F/T dependiendo si encuentra o no coincidencia
            string consulta = String.Format("UPDATE empleado SET alta=FALSE WHERE nif = '{0}' and alta=True;", nif); //Query
            MySqlCommand comando = new MySqlCommand(consulta, conexion); //Se instancia la clase command para la consulta                       
            //MessageBox.Show(consulta); //Comprobacion
            retorno = comando.ExecuteNonQuery(); //Lanza la consulta
            exist = retorno > 0 ? true : false; //Almacenara F/T dependiendo si encuentra o no coincidencia

            return exist;
        }
        /// <summary>
        /// Hace un delete en la base de datos a partir del nif del empleado y si esta dado de baja
        /// </summary>
        /// <param name="conexion"></param>
        /// <param name="nif"></param>
        /// <returns>Devuelve el numero de filas eliminadas</returns>
        public int BorrarEmpleado(MySqlConnection conexion, string nif)
        {
            int retorno;            
            string consulta = String.Format("DELETE FROM empleado WHERE nif = '{0}'", nif); //Query
            MySqlCommand comando = new MySqlCommand(consulta, conexion); //Se instancia la clase command para la consulta
            //MessageBox.Show(consulta); //Comprobacion
            retorno = comando.ExecuteNonQuery(); //Lanza la consulta          
            return retorno;
        }

        /// <summary>
        /// Realiza un insert en la tabla empleados
        /// </summary>
        /// <param name="conexion"></param>
        /// <returns>Devuelve un true/false si se ha hecho modificacion en la base de datos</returns>
        public bool AgregarEmpleado(MySqlConnection conexion)
        {
            int retorno;
            bool agregado;
            string consulta = //Consulta
            String.Format("INSERT INTO empleado (alta,nif,nombre,apellidos,administrador,contraseña) VALUES" +
            "({0},'{1}','{2}','{3}',{4},'{5}');",alta,nif,nombre,apellidos,administrador,contraseña);
            //MessageBox.Show(consulta); //Comprobacion
            MySqlCommand command = new MySqlCommand(consulta, conexion);
            retorno = command.ExecuteNonQuery(); //Lanza la consulta
            agregado = retorno > 0 ? true : false; //Almacenara F/T dependiendo si encuentra o no coincidencia
            return agregado;
        }
        #endregion
    }
}
