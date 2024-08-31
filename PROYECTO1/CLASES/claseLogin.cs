using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PROYECTO1.CLASES
{
    internal class claseLogin
    {

        public Boolean acceso(string usuario, string clave)
        {
            if ((usuario == "omar") && (clave == "123"))
            {
                return true;
            }
            else { return false; }


        }
    }
}
