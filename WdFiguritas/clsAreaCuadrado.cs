using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WdFiguritas
{
    class clsAreaCuadrado
    {
        private double Area = 0;

        public clsAreaCuadrado(double Lado)
        {
            Area = Lado*Lado;
        }

        public double obtenAreaCdr()
        {
            return Area;
        }
    }
}
