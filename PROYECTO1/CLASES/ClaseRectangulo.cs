using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASO2.Clases
{
    internal class ClaseRectangulo
    {

        public double areaRecta(double lado1,double lado2)
            {
            return lado1 * lado2; 
            }

        public double perimetroRecta(double lado1, double lado2)
        {
            return (2 * lado1) + (2 * lado2);
        }
    }
}
