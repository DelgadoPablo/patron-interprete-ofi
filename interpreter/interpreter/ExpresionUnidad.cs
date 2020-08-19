using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interpreter
{
    class ExpresionUnidad : Expresion
    {
        public override string Unidad()
        {
            return "I";

        }
        public override string Cuatro()
        {
            return "IV";

        }
        public override string Cinco()
        {
            return "V";

        }
        public override string Nueve()
        {
            return "IX";

        }
        public override int Factor()
        {
            return 1;

        }
    }

}
