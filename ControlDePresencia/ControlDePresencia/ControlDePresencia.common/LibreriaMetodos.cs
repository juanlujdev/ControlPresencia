using Renci.SshNet.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlDePresencia
{
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
    }
}
