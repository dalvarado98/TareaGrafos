using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafoND
{
    public class NodoLista : Nodo
    {
       
        public NodoLista anterior { get; set; }
        public NodoLista siguiente { get; set; }


        public NodoLista(string pdato) : base(pdato)
        {
            anterior = null;
            siguiente = null;
        }
    }
}
