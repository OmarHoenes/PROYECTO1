using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO1.CLASES
{
    internal class claseEcuacion2
    {

        public double ecuacion11(double a, double b, double c)
        {
            return (-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a); 
            
        }
        public double ecuacion12(double a, double b, double c)
        {
            return (-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
        }

    }
}
