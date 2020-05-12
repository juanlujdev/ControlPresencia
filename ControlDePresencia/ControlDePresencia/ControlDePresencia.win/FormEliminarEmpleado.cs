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
        private string nif;
        public string Nif { get { return nif; } }

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
            this.nif = txtDni.Text;
            this.Close();
        }

        private void FormEliminarEmpleado_Load(object sender, EventArgs e)
        {

        }
    }
}
