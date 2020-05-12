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
    public partial class FormPrincipal : Form
    {
        MySqlConnection conexion = BDatos.ConexionBD(); //Instancia el objeto MySqlConnection

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        #region Manejadores
        private void lblEntrada_Click(object sender, EventArgs e)
        {
            //Comprueba si el txt box del dni esta vacio
            if (txtDni.Text == "")
            {
                MessageBox.Show("El campo del DNI no puede estar vacio");
                return;
            }
            string nif = txtDni.Text.ToUpper();
            try
            {
                //Abre la conexion
                if (BDatos.AbrirConexion())
                {
                    //Comprueba si la letra del DNI es correcta
                    if (!LibreriaMetodos.ComprobarLetra(nif))
                    {
                        MessageBox.Show("NIF incorrecto"); return;
                    }

                    //Comprueba si el empleado existe
                    if (!LibreriaMetodos.ComprobarEmpleado(nif, conexion))
                    {
                        MessageBox.Show("El empleado no existe"); return;
                    }

                    //Comprueba el fichaje
                    if (LibreriaMetodos.ComprobarFichaje(nif, conexion))
                    {
                        MessageBox.Show("El empleado ya ha fichado");
                        return;
                    }
                    else
                    {
                        //Si el empleado no ha fichado, le da de alta en fichaje
                        Fichaje fichaje = new Fichaje(nif, DateTime.Now, DateTime.MinValue, false);
                        if (fichaje.DarAlta(conexion))
                        {
                            MessageBox.Show(String.Format("Entrada del empleado a fecha {0}", DateTime.Now));
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No se ha establecido la conexión", "Error");
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

        private void btnSalida_Click(object sender, EventArgs e)
        {
            if (txtDni.Text == "")
            {
                MessageBox.Show("El campo del DNI no puede estar vacio");
                return;
            }
            string nif = txtDni.Text.ToUpper();
            try
            {
                if (BDatos.AbrirConexion())
                {
                    if (!LibreriaMetodos.ComprobarLetra(nif))
                    {
                        MessageBox.Show("NIF incorrecto"); return;
                    }

                    if (!LibreriaMetodos.ComprobarEmpleado(nif, conexion))
                    {
                        MessageBox.Show("El empleado no existe"); return;
                    }

                    //Comprueba si el empleado ha fichado previamente
                    if (LibreriaMetodos.ComprobarFichaje(nif, conexion))
                    {
                        //MessageBox.Show("Si que hay fichaje previo");//Comprobacion
                    }
                    else { MessageBox.Show("El empleado no ha fichado") ;return; }

                    //Si hay fichaje previo, lo finaliza
                    Fichaje fichaje = new Fichaje();
                    if (fichaje.DarSalida(conexion, nif))
                    {
                        MessageBox.Show(String.Format("Salida del empleado a fecha {0}",DateTime.Now));
                    }
                    else {return; }
                }
                else
                {
                    MessageBox.Show("No se ha establecido la conexión","Error");
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

        private void btnPresencia_Click(object sender, EventArgs e)
        {
            try
            {
                if (BDatos.AbrirConexion())
                {
                    FormPresencia presencia = new FormPresencia();
                    presencia.ShowDialog();
                }
            }catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                BDatos.CerrarConexion();
            }  
        }

        private void btnPermanencia_Click(object sender, EventArgs e)
        {
            if (txtDni.Text == "")
            {
                MessageBox.Show("El campo del DNI no puede estar vacio");
                return;
            }
            string nif = txtDni.Text.ToUpper();
            try
            {
                if (BDatos.AbrirConexion())
                {
                    if (!LibreriaMetodos.ComprobarLetra(nif))
                    {
                        MessageBox.Show("NIF incorrecto"); return;
                    }

                    if (LibreriaMetodos.ComprobarEmpleado(nif, conexion))
                    {
                    FrmPermanencia permanencia = new FrmPermanencia(nif);// Si todo es ok abre el formulario                            
                    permanencia.ShowDialog();
                    }
                    else { MessageBox.Show("No existe el empleado"); return; }
                }
                else
                {
                    MessageBox.Show("No se ha establecido la conexión", "Error");
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

        private void btnMantenimiento_Click(object sender, EventArgs e)
        {
            if (txtDni.Text == "")
            {
                MessageBox.Show("El campo del DNI no puede estar vacio");
                return;
            }
            string nif = txtDni.Text.ToUpper();          
            try
            {
                if (BDatos.AbrirConexion())
                {
                    if (!LibreriaMetodos.ComprobarLetra(nif))
                    {
                        MessageBox.Show("NIF incorrecto"); return;
                    }
                    
                    if (!LibreriaMetodos.ComprobarEmpleado(nif, conexion))
                    {
                        MessageBox.Show("El empleado no existe"); return;
                    }

                    if (!LibreriaMetodos.ComprobarAdmin(nif, conexion))
                    {
                        MessageBox.Show("El empleado no es administrador"); return;
                    } 
                    //Si el empleado es adminitrador , instancia el from para que introduzca la contraseña
                    FrmContraseñaMantenimiento mantenimiento = new FrmContraseñaMantenimiento();
                    mantenimiento.ShowDialog();
                    string contraseña = mantenimiento.Contraseña;
                    if (!mantenimiento.Ok) return; //La validacion del formulario de la contraseña no esta correcta y corta.
                    //Si la contraseña es correcta abre el formulario de mantenimiento
                    if (LibreriaMetodos.ComprobarPassword(contraseña, conexion))
                    {                              
                        FormMantenimiento manteni = new FormMantenimiento();                                   
                        manteni.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Contraseña Erronea");
                    }
                }
                else
                {
                    MessageBox.Show("No se ha establecido la conexión", "Error");
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

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        #endregion

        private void lblReloj_Click(object sender, EventArgs e)
        {

        }

        private void tmrReloj_Tick_1(object sender, EventArgs e)
        {
            lblReloj.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
