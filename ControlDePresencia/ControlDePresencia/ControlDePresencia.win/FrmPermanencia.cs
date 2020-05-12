﻿using System;
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
    public partial class FrmPermanencia : Form
    {
        MySqlConnection conexion = BDatos.ConexionBD();

        public FrmPermanencia(string nif)//le paso al constructor el nif del form principal previamente comprobado letra y usuario de alta
        {
            InitializeComponent();
            lblMostrarDni.Text = nif;//introduzco los datos en el label
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmPermanencia_Load(object sender, EventArgs e)
        {
            
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                if (BDatos.AbrirConexion())
                {
                    DateTime fecha1 = dtpFecha1.Value;
                    DateTime fecha2 = dtpFecha2.Value;
                    string nif = lblMostrarDni.Text;//como tengo los datos en el label, puedo pasarlos al metodo mostrarFichaje()
                    BindingSource lista = LibreriaMetodos.MostrarFichaje(fecha1, fecha2, conexion ,nif);
                    dgvPermanencia.DataSource = lista;
                }
                else
                {
                    MessageBox.Show("No se ha podido abrir la conexion.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
            }
            finally  // en cualquier caso cierro la conexión (haya error o no)
            {
                BDatos.CerrarConexion();
            }
        }

        private void dgvPermanencia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvPermanencia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            double tiempo = 0;
            for (int i=0; i < dgvPermanencia.Rows.Count; i++)
            {
                tiempo += Convert.ToInt32(dgvPermanencia.Rows[i].Cells[2].Value);
            }
            double horas = tiempo / 60;
            MessageBox.Show(String.Format("El empleado ha fichado un total de:\nMinutos:  {0}\nHoras:  {1:00.00}",tiempo,horas));
        }
    }
}