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
                    if (LibreriaMetodos.ComprobarLetra(nif))
                    {
                        MessageBox.Show("Coincide la letra"); //Comprobacion

                        if (LibreriaMetodos.ComprobarEmpleado(nif, conexion))
                        {
                            MessageBox.Show("Si que se obtuvo coincidencia en empleados"); //Comprobacion

                            if (LibreriaMetodos.ComprobarFichaje(nif, conexion))
                            {
                                //No hace nada
                                MessageBox.Show("Si obtuvo coincidencia en fichajes");
                            }
                            else
                            {
                                //Dar de alta en fichaje
                                MessageBox.Show("No obtuvo coincidencia en fichajes");
                                Fichaje fichaje = new Fichaje(nif, DateTime.Now, DateTime.MinValue,false);
                                if (fichaje.DarAlta(conexion))
                                {
                                    MessageBox.Show("Se ha dado de alta");
                                }
                                else
                                {
                                    MessageBox.Show("Fallo al dar de alta");
                                }
                            }
                        } else MessageBox.Show("El empleado no existe");
                    } else MessageBox.Show("La letra no coincide");
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
            string nif = txtDni.Text;
            try
            {
                if (BDatos.AbrirConexion())
                {
                    if (LibreriaMetodos.ComprobarLetra(nif))
                    {
                        MessageBox.Show("Coincide la letra"); //Comprobacion

                        if (LibreriaMetodos.ComprobarEmpleado(nif, conexion))
                        {
                            MessageBox.Show("Si que se obtuvo coincidencia en empleados"); //Comprobacion

                            if (LibreriaMetodos.ComprobarFichaje(nif, conexion))
                            {
                                //Si hay coincidencia, da salida
                                Fichaje fichaje = new Fichaje();
                                if(fichaje.DarSalida(conexion, nif))
                                {
                                    MessageBox.Show("Se ha dado salida");
                                }
                                else
                                {
                                    MessageBox.Show("No se  ha dado salida");
                                }
                            }else MessageBox.Show("No hay coincidencia de fichaje");
                        }
                        else MessageBox.Show("El empleado no existe");
                    }
                    else MessageBox.Show("La letra no coincide");
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
            string nif = txtDni.Text;
            try
            {
                if (BDatos.AbrirConexion())
                {
                    if (LibreriaMetodos.ComprobarLetra(nif))
                    {
                        MessageBox.Show("Coincide la letra"); //Comprobacion

                        if (LibreriaMetodos.ComprobarEmpleado(nif, conexion))
                        {
                            MessageBox.Show("Si que se obtuvo coincidencia en empleados"); //Comprobacion  
                            FrmPermanencia permanencia = new FrmPermanencia(nif);// Si todo es ok abre el formulario                            
                            permanencia.ShowDialog();
                        }
                        else MessageBox.Show("El empleado no existe");
                    }
                    else MessageBox.Show("La letra no coincide");
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

           
        }
    }
}
