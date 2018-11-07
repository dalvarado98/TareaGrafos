using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafoND
{
  public  class Nodo
    {
        public int Dato { get; set; }
        public Nodo Anterior { get; set; }
        public Nodo Siguiente { get; set; }

        public Nodo()
        {
            this.Dato = 0;
            this.Siguiente = null;
            this.Anterior = null;
        }
    }
}
