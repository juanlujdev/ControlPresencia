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
    public partial class FormDatos : Form
    {
        //Atributos y propiedades para pasar los datos de un form a otro
        private string nif;
        private string nombre;
        private string apellidos;
        private string contraseña;
        private bool alta;
        private bool administrador;

        public string Nif { get { return nif; } }
        public string Nombre { get {return  nombre; } }
        public string Apellidos { get {return  apellidos; } }
        public string Contraseña { get {return  contraseña; } }
        public bool Alta { get {return  alta; } }
        public bool Administrador { get {return  administrador; } }


        public FormDatos()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            this.nif = txtNif.Text;
            this.nombre = txtNombre.Text;
            this.apellidos = txtApellido.Text;
            this.alta = cbxAlta.Checked ? true : false;
            if (cbxAdministrador.Checked)
            {
                this.administrador = true;
                if (txtContraseña.Text == "") MessageBox.Show("Es necesaria una contraseña");
                this.contraseña = txtContraseña.Text;
            }
            else
            {
                this.administrador = false;
                this.contraseña = null;
            }
            this.Close();
        }

        private void FormDatos_Load(object sender, EventArgs e)
        {

        }
    }
}
