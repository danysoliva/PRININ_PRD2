using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRININ.Classes
{
    public class Functions
    {
        public Functions()
        {

        }

        public string QuitSpecialChar(string pOriginal)
        {
            
            string cadena = pOriginal.Replace(',',' ');
            cadena = cadena.Replace('.', ' ');
            cadena = cadena.Replace(';', ' ');
            cadena = cadena.Replace(':', ' ');
            cadena = cadena.Replace('_', ' ');
            cadena = cadena.Replace('/', ' ');
            cadena = cadena.Replace('@', ' ');
            cadena = cadena.Replace('*', ' ');
            cadena = cadena.Replace(')', ' ');
            cadena = cadena.Replace('(', ' ');
            cadena = cadena.Replace('%', ' ');
            cadena = cadena.Replace('$', ' ');
            cadena = cadena.Replace('#', ' ');
            cadena = cadena.Replace('¿', ' ');
            cadena = cadena.Replace('¡', ' ');
            cadena = cadena.Replace('!', ' ');
            cadena = cadena.Replace('=', ' ');
            cadena = cadena.Replace('&', ' ');
            cadena = cadena.Replace('|', ' ');
            cadena = cadena.Replace('°', ' ');
            cadena = cadena.Replace('¬', ' ');
            cadena = cadena.Replace('+', ' ');
            cadena = cadena.Replace('}', ' ');
            cadena = cadena.Replace('{', ' ');
            cadena = cadena.Replace(']', ' ');
            cadena = cadena.Replace('[', ' ');
            cadena = cadena.Replace('ñ', 'n');
            cadena = cadena.Replace(',', ' ');
            cadena = cadena.Replace('¨', ' ');
            cadena = cadena.Replace('~', ' ');
            cadena = cadena.Replace('^', ' ');
            cadena = cadena.Replace('<', ' ');
            cadena = cadena.Replace('>', ' ');
            cadena = cadena.Replace('-', ' ');
            return cadena;
        }

    }
}
