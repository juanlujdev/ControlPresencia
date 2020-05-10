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
        private string nif;
        private DateTime horaEntrada;
        private DateTime horaSalida;
        private bool entrada;
        private bool salida;

        public string Nif { get {return nif; } set { nif = value; } }
        public DateTime HoraEntrada { get {return horaEntrada; } set { horaEntrada = value; } }
        public DateTime HoraSalida { get {return horaSalida; } set { horaSalida = value; } }
        public bool Entrada { get {return entrada; } set { entrada = value; } }
        public bool Salida { get {return salida; } set { salida = value; } }

        public Fichaje()
        {

        }
        public Fichaje(string nif, DateTime hE, DateTime hS, bool e,bool s)
        {
            this.nif = nif;
            horaEntrada = hE;
            horaSalida = hS;
            entrada = e;
            salida = s;
        }
        public bool DarAlta(MySqlConnection conexion)
        {
            int retorno;
            bool alta;

            string consulta = 
            String.Format("INSERT INTO fichaje (nif,horaEntrada,horaSalida,entrada,salida) " +
            "VALUE ('{0}','{1}','{2}',{3},{4});", nif,horaEntrada.ToString("yyyy-MM-dd hh:mm:ss"),horaSalida,entrada,salida);
            MessageBox.Show(consulta);
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
            String.Format("UPDATE fichaje SET horaSalida = '{0}', salida = TRUE WHERE nif = '{1}' AND salida = false;"
            ,horaSalida.ToString("yyyy-MM-dd hh:mm:ss"),nif);
            MessageBox.Show(consulta);
            MySqlCommand command = new MySqlCommand(consulta, conexion);
            retorno = command.ExecuteNonQuery();
            alta = retorno > 0 ? true : false;

            return alta;
        }

    }
}
