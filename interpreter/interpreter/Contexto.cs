using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interpreter
{
    class Contexto  // clase
    {
        // datos
        private string expresion;           
        private int valor;

        // propiedades
        public string Expresion { get => expresion; set => expresion = value; }
        public int Valor { get => valor; set => valor = value; }


        //// colocamos la expresion a interpretar

        public Contexto(string Pexpresion)
        {
            expresion = Pexpresion;

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("se evaluara {0}", expresion);

        }

    }
}
