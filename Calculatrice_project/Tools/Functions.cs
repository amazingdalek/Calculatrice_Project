using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using org.mariuszgromada.math.mxparser;


namespace Calculatrice_project.Tools
{
    public static class Functions
    {
        public static double calculerResultat(String calcul)
        {
            calcul = calcul.Replace(',', '.');
            Expression e = new Expression(calcul);
            return e.calculate();
        }
    }
}
