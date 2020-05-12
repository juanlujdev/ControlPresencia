#region Usings
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
#endregion

namespace ControlDePresencia
{
    public partial class FrmContraseñaMantenimiento : Form
    {
        //Atributos y propiedades para traernos la informacion entre formularios
        private string contraseña;
        private bool ok;

        public string Contraseña { get { return contraseña; } }
        public bool Ok { get { return ok; } }

        #region Validacion
        private bool Validacion()
        {
            bool ok = true;

            if (txtContraseña.Text == "")
            {
                ok = false;
                errPCnt.SetError(txtContraseña, "Introduce la contraseña");
            }
            else
            {
                errPCnt.SetError(txtContraseña, "");
            }

            return ok;
        }
        #endregion

        public FrmContraseñaMantenimiento()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            if (!Validacion()) return;
            this.ok = true;
            this.contraseña = txtContraseña.Text;
            this.Close();
        }

        private void FrmContraseñaMantenimiento_Load(object sender, EventArgs e)
        {

        }
    }
}
