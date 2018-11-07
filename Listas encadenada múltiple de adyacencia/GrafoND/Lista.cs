using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafoND
{
   public class Lista
    {
        private Nodo Cabezera;
        private Nodo Ultimo;

        public Lista()
        {
            Cabezera = new Nodo();
            Ultimo = new Nodo();
        }
    }
}
