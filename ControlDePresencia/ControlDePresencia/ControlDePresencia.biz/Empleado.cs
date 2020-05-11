using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlDePresencia.ControlDePresencia.biz
{
    class Empleado
    {
        private bool alta;
        private string nif;
        private string nombre;
        private string apellidos;
        private bool administrador;
        private string contraseña;

        public bool Alta { get { return alta; } set { alta = value; } }
        public string Nif { get { return nif; } set { nif = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Apellidos { get { return apellidos; } set { apellidos = value; } }
        public bool Administrador { get { return administrador; } set { administrador = value; } }
        public string Contraseña { get { return contraseña; } set { contraseña = value; } }

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

        public void EliminarEmpleado()
        {

        }

        public bool AgregarEmpleado(MySqlConnection conexion)
        {
            int retorno;
            bool agregado;
            string consulta =
            String.Format("INSERT INTO empleado (alta,nif,nombre,apellidos,administrador,contraseña) VALUES" +
            "({0},'{1}','{2}','{3}',{4},'{5}');",alta,nif,nombre,apellidos,administrador,contraseña);
            MessageBox.Show(consulta);
            MySqlCommand command = new MySqlCommand(consulta, conexion);
            retorno = command.ExecuteNonQuery();
            agregado = retorno > 0 ? true : false;
            return agregado;
        }
    }
}
