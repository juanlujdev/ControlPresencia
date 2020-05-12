using System;
using MySql.Data.MySqlClient;
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
    public partial class FormEliminarEmpleado : Form
    {
        #region Atributos
        private string nif;
        private bool ok;
        #endregion
        #region Propiedades
        public string Nif { get { return nif; } }
        public bool Ok { get { return ok; } }
        #endregion

        #region Validacion
        private bool ValidarDatos()
        {
            string Dni = txtDni.Text;
            bool ok = true;
            if ((txtDni.Text == "") || (txtDni.Text.Length < 9 || txtDni.Text.Length > 9))
            {
                ok = false;
                errorPrDni.SetError(txtDni,"Ingresa el Dni o introduce un DNI correcto");
            }
            else
            {
                errorPrDni.SetError(txtDni, "");
            }
            return ok;
        }
        #endregion

        public FormEliminarEmpleado()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void btnComprobar_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos()) return;
            this.ok = true;
            this.nif = txtDni.Text;
            this.Close();
        }

        private void FormEliminarEmpleado_Load(object sender, EventArgs e)
        {

        }
    }
}
