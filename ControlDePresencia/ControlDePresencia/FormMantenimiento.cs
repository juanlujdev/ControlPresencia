using ControlDePresencia.ControlDePresencia.biz;
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
    public partial class FormMantenimiento : Form
    {
        MySqlConnection conexion = BDatos.ConexionBD();

        public FormMantenimiento()
        {
            InitializeComponent();
        }

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            FormDatos formDatos = new FormDatos();
            formDatos.ShowDialog();

            string nif = formDatos.Nif;
            string nombre = formDatos.Nombre;
            string apellidos = formDatos.Apellidos;
            bool alta = formDatos.Alta;
            bool administrador = formDatos.Administrador;
            string contraseña = formDatos.Contraseña;

            try
            {
                if (BDatos.AbrirConexion())
                {
                    Empleado empleado = new Empleado(alta, nif, nombre, apellidos, administrador, contraseña);

                    if (LibreriaMetodos.ComprobarEmpleado(nif, conexion))
                    {
                        MessageBox.Show("El empleado ya existe");
                    }
                    else
                    {
                        empleado.AgregarEmpleado(conexion);
                        MessageBox.Show("empleado agregado");
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                BDatos.CerrarConexion();
            }
        }
    }
}
