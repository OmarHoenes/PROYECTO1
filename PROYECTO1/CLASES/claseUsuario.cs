using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO1.CLASES
{
    internal class usuario
    {
        public string nombre { get; set; }
        public int puntos { get; set; }

        public string cadena (string nombre, int puntos)
        {
            return nombre + "|" + puntos;
        }
    }
}
