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
        public void EliminarEmpleado()
        {

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
