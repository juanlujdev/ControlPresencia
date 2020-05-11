using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlDePresencia
{
    public partial class FormMantenimiento : Form
    {
        public FormMantenimiento()
        {
            InitializeComponent();
        }

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            FormDatos formDatos = new FormDatos();
            string nif = formDatos.Nif;
            string nombre = formDatos.Nombre;
            string apellidos = formDatos.Apellidos;
            bool alta = formDatos.Alta;
            bool administrador = formDatos.Administrador;
            string contraseña = formDatos.Contraseña;


        }
    }
}
