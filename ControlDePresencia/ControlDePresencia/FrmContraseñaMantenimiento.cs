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
    public partial class FrmContraseñaMantenimiento : Form
    {
        private string contraseña;
        public string Contraseña { get { return contraseña; } }

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
            this.contraseña = txtContraseña.Text;
            this.Close();

        }

        private void FrmContraseñaMantenimiento_Load(object sender, EventArgs e)
        {

        }
    }
}
