#region Usings
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#endregion

namespace ControlDePresencia
{
    public partial class FormDatos : Form
    {
        //Atributos y propiedades para pasar los datos de un form a otro
        #region Atributos 
        private string nif;
        private string nombre;
        private string apellidos;
        private string contraseña;
        private bool alta;
        private bool administrador;
        private bool ok;
        #endregion

        #region Propiedades
        public string Nif { get { return nif; } }
        public string Nombre { get {return  nombre; } }
        public string Apellidos { get {return  apellidos; } }
        public string Contraseña { get {return  contraseña; } }
        public bool Alta { get {return  alta; } }
        public bool Administrador { get {return  administrador; } }
        public bool Ok { get {return  ok; } }
        #endregion

        #region validacion
        private bool ValidarDatos()
        {
            bool ok = true;

            if (txtNif.Text == "")
            {
                ok = false;
                errpDatos.SetError(txtNif, "Ingresa Nif");
            }
            else
            {
                errpDatos.SetError(txtNif, "");
            }

            if (txtNombre.Text == "")
            {
                ok = false;
                errpDatos.SetError(txtNombre, "Ingresa Nombre");
            }
            else
            {
                errpDatos.SetError(txtNombre, "");
            }

            if (txtApellido.Text == "")
            {
                ok = false;
                errpDatos.SetError(txtApellido, "Ingresa Apellido");
            }
            else
            {
                errpDatos.SetError(txtApellido, "");
            }
            return ok;
        }

        #endregion

        public FormDatos()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        #region Manejadores
        private void btnSalida_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos()) return;

            this.ok = true; //Se han validados los datos, se pone a true
            this.nif = txtNif.Text;
            this.nombre = txtNombre.Text;
            this.apellidos = txtApellido.Text;
            this.alta = cbxAlta.Checked ? true : false;
            if (cbxAdministrador.Checked)
            {
                //Si se selecciona la casilla de admin, se requiere contraseña
                this.administrador = true;
                if (txtContraseña.Text == "") { MessageBox.Show("Es necesaria una contraseña"); return; }
                this.contraseña = txtContraseña.Text;
            }
            else
            {
                //Si no es admin la contraseña se establece a null
                this.administrador = false;               
                this.contraseña = null;
            }
            this.Close();
        }

        private void FormDatos_Load(object sender, EventArgs e)
        {
            txtContraseña.ReadOnly = true;
            txtNif.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Manejadores de CheckBox
        private void cbxAdministrador_CheckedChanged(object sender, EventArgs e)
        {
        
        }

        private void cbxAdministrador_CheckStateChanged(object sender, EventArgs e)
        {
            if (!cbxAdministrador.Checked)  txtContraseña.ReadOnly = true;
            if (cbxAdministrador.Checked)  txtContraseña.ReadOnly = false;
        }
        #endregion


    }
}
