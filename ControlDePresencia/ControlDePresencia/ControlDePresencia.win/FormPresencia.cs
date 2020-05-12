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
    public partial class FormPresencia : Form
    {
        MySqlConnection conexion = BDatos.ConexionBD();
        

        public FormPresencia()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FormPresencia_Load(object sender, EventArgs e)
        {
            try
            {
                if (BDatos.AbrirConexion())
                {
                    BindingSource lista = LibreriaMetodos.MostrarEmpleado(conexion);
                    dgvListado.DataSource = lista;
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
        private void dgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    
}

       
    

