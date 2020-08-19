using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            string expresionEvaluar = "X";
            Contexto contexto = new Contexto(expresionEvaluar);


            List<Expresion> Arbol = new List<Expresion>();
            Arbol.Add(new ExpresionMiles());
            Arbol.Add(new ExpresionCientos());
            Arbol.Add(new ExpresionDecenas());
            Arbol.Add(new ExpresionUnidad());

            foreach (Expresion exp in Arbol)
            {
                exp.Interpretar(contexto);
            }
            Console.WriteLine("El Numero Romano {0} es {1} en decimal", expresionEvaluar, contexto.Valor);

            Console.ReadLine();
            
        }
        
        
    }
}
