#region Usings
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
#endregion

namespace ControlDePresencia
{
    public partial class FormMantenimiento : Form
    {
        MySqlConnection conexion = BDatos.ConexionBD();

        public FormMantenimiento()
        {
            InitializeComponent();
        }

        #region Funciones
        private void CargarDGV()
        {
            try
            {
                if (BDatos.AbrirConexion())
                {
                    BindingSource listaEmpleados = LibreriaMetodos.MostrarTodoEmpleado(conexion);
                    dgvEmpleados.DataSource = listaEmpleados;
                    BindingSource listaFichajes = LibreriaMetodos.MostrarFichaje(conexion);
                    dgvFichajes.DataSource = listaFichajes;
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

        private void CargarDgvFichaje(string nif)
        {
            try
            {
                if (BDatos.AbrirConexion())
                {
                    BindingSource listaFichajes = LibreriaMetodos.MostrarFichaje(conexion,nif);
                    dgvFichajes.DataSource = listaFichajes;
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
        #endregion

        #region Manejadores
        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            //abre y obtiene los datos del formulario , FormDatos
            FormDatos formDatos = new FormDatos(); 
            formDatos.ShowDialog();

            string nif = formDatos.Nif;
            string nombre = formDatos.Nombre;
            string apellidos = formDatos.Apellidos;
            bool alta = formDatos.Alta;
            bool administrador = formDatos.Administrador;
            string contraseña = formDatos.Contraseña;
            bool ok = formDatos.Ok; //validación para evitar traer campos vacios

            try
            {
                if (BDatos.AbrirConexion())
                {
                    if (!ok) return; //Si ok es false no hace nada

                    Empleado empleado = new Empleado(alta, nif, nombre, apellidos, administrador, contraseña);

                    //Comprueba si el empleado existe
                    if (LibreriaMetodos.ComprobarEmpleado(nif, conexion))
                    {
                        MessageBox.Show("El empleado ya existe");
                    }
                    else
                    {
                        empleado.AgregarEmpleado(conexion);
                        MessageBox.Show("Empleado agregado");
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

        private void FormMantenimiento_Load(object sender, EventArgs e)
        {
           CargarDGV(); //Caga los dgv al inciar el form
        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            this.Close();  
        }

        private void btnInforme_Click(object sender, EventArgs e)
        {
            CargarDGV(); //Refresca los DGV
        }

        private void dgvFichajes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex; //Almacena la posición donde se ha hecho dobleclik en el dgv
            string nif = dgvFichajes.Rows[n].Cells[0].Value.ToString(); //Saca el nif del cell
            CargarDgvFichaje(nif);
        }
    }
    #endregion
}
