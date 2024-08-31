using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO1.CLASES
{
    internal class clasePitagoras
    {
        public double c1 (double a, double b)
        {

            return Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

        }

        public double a1(double c, double b)
        {
            return Math.Sqrt(Math.Pow(c, 2) + Math.Pow(b, 2));
        }

        public double b1 (double c, double a) 
        {
            return Math.Sqrt(Math.Pow(c, 2) + Math.Pow(a, 2));
        }
    }
}
