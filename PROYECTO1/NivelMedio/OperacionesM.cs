using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO1.NivelMedio
{
    internal class OperacionesM
    {
        //Operaciones usadas para el Formulario Calculo de la Pendiente
        public int valorX(int min, int max)
        {
            Random r = new Random(DateTime.Now.Second);
            return r.Next(min, max);
        }
        public int valorY(int min, int max)
        {
            Random r = new Random(DateTime.Now.Millisecond);
            return r.Next(min, max);
        }
        public int valorCiclo(int min, int max)
        {
            Random r = new Random();
            return r.Next(min, max);
        }
        //Generamos metodos para el calculo de los resultados del sistema
        public int ys(int m, int x1, int b)
        {
            return (m * x1) + b;
        }
        public int ms(int m, int x1, int b, int b1)
        {
            return (ys(m, x1, b) - b1) / x1;
        }
        //_____________________________________________________________________


        //Pendiente a partir de dos puntos
        //Generamos Metodos para las operaciones de Pendiente de dos Puntos x1,x2,y1,y2
        public int valorX1(int min, int max)
        {
            Random r = new Random(DateTime.Now.Second);
            return r.Next(min, max);
        }
        public int valorX2(int min, int max)
        {
            Random r = new Random(DateTime.Now.Second);
            return r.Next(min, max);
        }
        public int valorY1(int min, int max)
        {
            Random r = new Random(DateTime.Now.Millisecond);
            return r.Next(min, max);
        }
        public int valorY2(int min, int max)
        {
            Random r = new Random(DateTime.Now.Millisecond);
            return r.Next(min, max);
        }
        //Metodo para generar numeros aleatorios
        public int valorCiclo2(int min, int max)
        {
            Random r = new Random();
            return r.Next(min, max);
        }
        //Metodos calculo del sistema
        public int ys1(int m, int x1, int b)
        {
            return (m * x1) + b;
        }
        public int ms1(int m, int x1, int b, int b1)
        {
            return (ys(m, x1, b) - b1) / x1;
        }
    }
}
