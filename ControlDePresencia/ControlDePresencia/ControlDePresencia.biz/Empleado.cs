using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void EliminarEmpleado()
        {

        }
    }
}
