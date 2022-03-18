using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WdFiguritas
{
    class clsAreaCirculo
    {
        private double pi = 3.1416;
        private double Area = 0;

        public clsAreaCirculo(double Radio)
        {
            Area = pi * Radio * Radio;
        }

        public double obtenAreaCrl()
        {
            return Area;
        }
    }
}
