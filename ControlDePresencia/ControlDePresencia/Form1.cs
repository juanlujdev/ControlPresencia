using MySql.Data.MySqlClient;
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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }
        private void tmrReloj_Tick(object sender, EventArgs e)
        {
            lblReloj.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblReloj.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void lblEntrada_Click(object sender, EventArgs e)
        {
            string nif = txtDni.Text;
            if (LibreriaMetodos.ComprobarLetra(nif)) MessageBox.Show("Coincide la letra"); //Comprobacion
            if (LibreriaMetodos.ComprobarEmpleado(nif)) MessageBox.Show("Si que se obtuvo coincidencia"); //Comprobacion
        }

        private void btnSalida_Click(object sender, EventArgs e)
        {

        }
    }
}
