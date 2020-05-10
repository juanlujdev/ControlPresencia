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

        MySqlConnection conexion = BDatos.ConexionBD();

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
            try
            {
                if (BDatos.AbrirConexion())
                {
                    if (LibreriaMetodos.ComprobarLetra(nif)) MessageBox.Show("Coincide la letra"); //Comprobacion
                    if (LibreriaMetodos.ComprobarEmpleado(nif, conexion)) MessageBox.Show("Si que se obtuvo coincidencia"); //Comprobacion
                    if (LibreriaMetodos.ComprobarFichaje(nif,conexion))
                    {
                        //No hace nada
                        MessageBox.Show("Si obtuvo coincidencia");
                    }
                    else
                    {
                        //Hay que darlo de alta
                        MessageBox.Show("No obtuvo coincidencia");
                    }
                }
                else
                {
                    MessageBox.Show("No hay conexion");
                };
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                BDatos.CerrarConexion();
            }
            //if (LibreriaMetodos.ComprobarLetra(nif)) MessageBox.Show("Coincide la letra"); //Comprobacion
            //if (LibreriaMetodos.ComprobarEmpleado(nif)) MessageBox.Show("Si que se obtuvo coincidencia"); //Comprobacion
        }

        private void btnSalida_Click(object sender, EventArgs e)
        {

        }

        private void btnPresencia_Click(object sender, EventArgs e)
        {
            FormPresencia presencia = new FormPresencia();
            presencia.ShowDialog();
        }

        private void btnPermanencia_Click(object sender, EventArgs e)
        {
            FrmPermanencia permanencia = new FrmPermanencia();
            permanencia.ShowDialog();
        }
    }
}
