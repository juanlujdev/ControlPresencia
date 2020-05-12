using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlDePresencia.ControlDePresencia.biz
{
    class Fichaje
    {
        #region Atributos
        private string nif;
        private DateTime horaEntrada;
        private DateTime horaSalida;
        private bool finalizar;
        #endregion

        #region Propiedades
        public string Nif { get {return nif; } set { nif = value; } }
        public DateTime HoraEntrada { get {return horaEntrada; } set { horaEntrada = value; } }
        public DateTime HoraSalida { get {return horaSalida; } set { horaSalida = value; } }
        public bool Finalizar { get {return finalizar; } set { finalizar = value; } }
        #endregion

        #region Constructores
        public Fichaje()
        {

        }
        public Fichaje(string nif, DateTime hE, DateTime hS, bool f)
        {
            this.nif = nif;
            horaEntrada = hE;
            horaSalida = hS;
            finalizar = f;
        }
        #endregion

        #region Metodos de interfaz
        /// <summary>
        /// Realiza un insert en la tabla fichajes
        /// </summary>
        /// <param name="conexion"></param>
        /// <returns>Devuelve un true/false si se ha hecho modificacion en la base de datos</returns>
        public bool DarAlta(MySqlConnection conexion)
        {
            int retorno;
            bool alta;
            string consulta = 
            String.Format("INSERT INTO fichaje (nif,horaEntrada,horaSalida,finalizar) " +
            "VALUE ('{0}','{1}','{2}',{3});", nif,horaEntrada.ToString("yyyy-MM-dd hh:mm:ss"),horaSalida,finalizar);
            //MessageBox.Show(consulta);
            MySqlCommand command = new MySqlCommand(consulta, conexion);
            retorno = command.ExecuteNonQuery();
            alta = retorno > 0 ? true : false;

            return alta;
        }

        public bool DarSalida(MySqlConnection conexion,string nif)
        {
            int retorno;
            bool alta;
            DateTime horaSalida = DateTime.Now;

            string consulta =
            String.Format("UPDATE fichaje SET horaSalida = '{0}', finalizar = TRUE WHERE nif = '{1}' AND finalizar = FALSE;"
            ,horaSalida.ToString("yyyy-MM-dd hh:mm:ss"),nif);
            //MessageBox.Show(consulta);
            MySqlCommand command = new MySqlCommand(consulta, conexion);
            retorno = command.ExecuteNonQuery();
            alta = retorno > 0 ? true : false;

            return alta;
        }
        #endregion

    }
}
