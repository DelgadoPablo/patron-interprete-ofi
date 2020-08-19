using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interpreter
{
    class ExpresionCientos: Expresion
    {
        public override string Unidad()
        {
            return "C";
        }
        public override string Cuatro()
        {
            return "CD";
        }
        public override string Cinco()
        {
            return "D";
        }
        public override string Nueve()
        {
            return "CM";
        }
        public override int Factor()
        {
            return 100;
        }
    }
}
