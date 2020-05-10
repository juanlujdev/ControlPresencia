using Renci.SshNet.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.CodeDom;

namespace ControlDePresencia
{   /// <summary>
    ///
    /// </summary>
    static class LibreriaMetodos
    {
        static public bool ComprobarLetra(string nif)
        {
            string tabla = "TRWAGMYFPDXBNJZSQVHLCKET";
            int indice;

            string soloNumeros = nif.Substring(0,nif.Length-1);//obtiene solo la numeracion del nif pasado por parametro
            int numeros = Convert.ToInt32(soloNumeros);
            indice = numeros % 23; //Calculo para sacar la poscion de la letra a raiz del numero del dno

            char letraCalculada = tabla[indice]; //letra que obtiene del calculo
            char letraParametro = nif[8]; //Letra del nif pasado por parametro
            if (letraCalculada == letraParametro) return true; return false;
        }

        static public bool ComprobarEmpleado(string nif, MySqlConnection conexion)
        {
            bool exist = false; //Almacenara F/T dependiendo si encuentra o no coincidencia
            string consulta = String.Format("SELECT * FROM empleado WHERE nif = '{0}' AND alta = {1};", nif,true); //Query
            MySqlCommand comando = new MySqlCommand(consulta, conexion); //Se instancia la clase command para la consulta
            MessageBox.Show(consulta); //Comprobacion
            //if (BDatos.AbrirConexion()) //Abre la conexion e intenta conectar ala BBDD, si da false no lo ha conseguido
            //{
            MySqlDataReader reader = comando.ExecuteReader(); //Lanza la consulta
            exist = reader.HasRows ? true : false;
            reader.Close();
            //BDatos.CerrarConexion(); //Se cierra la conexión una vez realizada la consulta correctamente
            //}
            //else
            //{
            //  MessageBox.Show("Conexion no establecida con la base de datos"); //No ha establecido conexioin
            //}
            return exist;
        }
        static public bool ComprobarFichaje(string nif, MySqlConnection conexion)
        {
            bool exist = false; //Almacenara F/T dependiendo si encuentra o no coincidencia
            string consulta = String.Format("SELECT * FROM fichaje WHERE nif = '{0}' AND finalizar = false;", nif); //Query
            MySqlCommand comando = new MySqlCommand(consulta, conexion); //Se instancia la clase command para la consulta
            MessageBox.Show(consulta); //Comprobacion
            //if (BDatos.AbrirConexion()) //Abre la conexion e intenta conectar ala BBDD, si da false no lo ha conseguido
            //{
            MySqlDataReader reader = comando.ExecuteReader(); //Lanza la consulta
            exist = reader.HasRows ? true : false;
            reader.Close();
            //BDatos.CerrarConexion(); //Se cierra la conexión una vez realizada la consulta correctamente
            //}
            //else
            //{
            //  MessageBox.Show("Conexion no establecida con la base de datos"); //No ha establecido conexioin
            //}
            return exist;
        }
        static public BindingSource MostrarEmpleado(MySqlConnection conexion)
        {
            string consulta  = "SELECT nombre, apellidos,horaEntrada FROM empleado INNER JOIN fichaje ON empleado.nif=fichaje.nif WHERE finalizar=FALSE";
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MessageBox.Show(consulta);
            MySqlDataReader reader = comando.ExecuteReader();
            BindingSource bs = new BindingSource(); ///QUE ES EXACTAMENTE?¿?¿?¿
            bs.DataSource = reader;
            reader.Close();
            return bs;         

        }
        static public BindingSource MostrarFichaje(DateTime fecha1, DateTime fecha2, MySqlConnection conexion, string nif)
        {
            string consulta = String.Format("SELECT horaEntrada, horaSalida, TIMESTAMPDIFF (MINUTE, {0}, {1}) AS Duracion_Minutos from fichaje WHERE finalizar='{2}' AND nif ='{3}';",fecha1.ToString("yyyy-MM-dd hh:mm:ss"),fecha2.ToString("yyyy-MM-dd hh:mm:ss"), true, nif);           
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MessageBox.Show(consulta);
            MySqlDataReader reader = comando.ExecuteReader();
            BindingSource bs = new BindingSource(); ///QUE ES EXACTAMENTE?¿?¿?¿
            bs.DataSource = reader;
            reader.Close();
            return bs;

        }
    }
}
