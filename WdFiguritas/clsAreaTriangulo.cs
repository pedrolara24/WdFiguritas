using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WdFiguritas
{
    class clsAreaTriangulo
    {
        private double Area = 0;

        public clsAreaTriangulo(double Base, double Altura)
        {
            Area = (Base * Altura)/2;
        }

        public double obtenAreaTrg()
        {
            return Area;
        }
    }
}
