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

        private void CargarDgvEmpleado(string nif)
        {
            try
            {
                if (BDatos.AbrirConexion())
                {
                    BindingSource listaEmpleados = LibreriaMetodos.MostrarEmpleado(conexion, nif);
                    dgvEmpleados.DataSource = listaEmpleados;
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
                    if (!ok) return; //Si ok es false no hace nada, porque la validacion del form de datos no es correcta

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
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);

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
            CargarDgvEmpleado(nif);
        }

        private void txtCerrar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0); //Sale de la aplicación , se aplica el valor 0 como que es una salida sin error.
        }

        private void btnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            FormEliminarEmpleado eliminar = new FormEliminarEmpleado();
            eliminar.ShowDialog();
            if (!eliminar.Ok) return;
            
            string nif = eliminar.Nif;
            try
            {
                if (BDatos.AbrirConexion())
                {
                    if (!LibreriaMetodos.ComprobarEmpleado(nif, conexion))
                    {
                        MessageBox.Show("El empleado no existe"); return;
                    }
                    //Pregunta si realmente quiere eliminar el empleado                
                    if (MessageBox.Show("Estas seguro que quieres eliminar este empleado?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                       //Pasa a false el atributo alta.
                       Empleado elimin = new Empleado();
                       elimin.EliminarEmpleado(conexion, nif);
                       MessageBox.Show(String.Format("Se ha eliminado el empleado con NIF: {0}", nif));
                    }                   
                }
                else
                {
                    MessageBox.Show("No se ha establecido la conexión", "Error");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
            }
            finally
            {
                BDatos.CerrarConexion();
            }
        }

        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgvEmpleados_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (BDatos.AbrirConexion())
                {
                    int n = e.RowIndex;
                    string nif = dgvEmpleados.Rows[n].Cells[1].Value.ToString();
                    if (MessageBox.Show("Se va ha eliminar el EMPLEADO Y SUS FICHAJES de la base de datos con DNI " + nif + ".\n Estas Seguro?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Empleado elimin = new Empleado();
                        int numRegistros = elimin.BorrarEmpleado(conexion, nif);
                        MessageBox.Show(String.Format("Se ha borrado el empleado y sus fichajes"));
                    }
                }
                else
                {
                    MessageBox.Show("No se ha establecido la conexión", "Error");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
            }
            finally
            {
                BDatos.CerrarConexion();
            }
        }

        private void dgvEmpleados_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
        }

        private void dgvEmpleados_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
    #endregion
}
