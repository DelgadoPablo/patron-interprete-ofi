using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interpreter
{
    abstract class Expresion  // clase
    {
        ///creacion del metodo para interpretar
        public void Interpretar(Contexto pContexto)
        {
            // si ya no hay elementos interpretar que salimos
            if (pContexto.Expresion.Length == 0)
                return;

            if (pContexto.Expresion.StartsWith(Nueve()))
            {
                // agregamos el nuevo por la posicion de donde este 1,10,100
                pContexto.Valor += (9 * Factor());

                // eliminamos dos caracteres IX, XC CM
                pContexto.Expresion = pContexto.Expresion.Substring(2);
            }
            else if (pContexto.Expresion.StartsWith(Cuatro()))
            {
                pContexto.Valor += (4 * Factor());
                //eliminamos dos caracteres
                pContexto.Expresion = pContexto.Expresion.Substring(2);

            } 



            else if (pContexto.Expresion.StartsWith(Cinco()))
            {
                pContexto.Valor += (5 * Factor());
                pContexto.Expresion = pContexto.Expresion.Substring(1);
            }
            while (pContexto.Expresion.StartsWith(Unidad()))

            {
                pContexto.Valor += (1 * Factor());
                pContexto.Expresion = pContexto.Expresion.Substring(1);
            }

        }


        // metodos implementados por las clases hijas de exprecion 
        public abstract string Unidad();
        public abstract string Cuatro();
        public abstract string Cinco();
        public abstract string Nueve();
        public abstract int Factor();
    }
}




