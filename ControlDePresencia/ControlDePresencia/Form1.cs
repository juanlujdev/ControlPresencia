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
            //Comprobacion Metodos Acceso a base de datos
            //BDatos.ConexionBD();
            //BDatos.AbrirConexion();
            //BDatos.CerrarConexion();

            //Comprobacion comprobar letra
            if (LibreriaMetodos.ComprobarLetra("33563572V")) MessageBox.Show("Letra del DNI correcta");


        }
    }
}
