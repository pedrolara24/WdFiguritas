using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WdFiguritas
{
    class clsAreaRectangulo
    {
        private double Area = 0;

        public clsAreaRectangulo(double Base, double Altura)
        {
            Area = Base*Altura;
        }

        public double obtenAreaRtg()
        {
            return Area;
        }
    }
}
