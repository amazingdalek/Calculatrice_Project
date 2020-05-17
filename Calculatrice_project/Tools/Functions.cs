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
        public static string calculerResultat(string calcul)
        {
            string resultat = "0";
            if (calcul != null && calcul != "")
            {
                calcul = calcul.Replace(',', '.');
                Expression e = new Expression(calcul);

                resultat = e.calculate().ToString("N");
            }
            return resultat;
        }
    }
}
