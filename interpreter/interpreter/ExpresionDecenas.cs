using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interpreter
{
    class ExpresionDecenas: Expresion
    {
        public override string Unidad()
        {
            return "X";
        }
        public override string Cuatro()
        {
            return "XL";
        }
        public override string Cinco()
        {
            return "L";
        }
        public override string Nueve()
        {
            return "XC";
        }
        public override int Factor()
        {
            return 10;
        }
    } 
}
