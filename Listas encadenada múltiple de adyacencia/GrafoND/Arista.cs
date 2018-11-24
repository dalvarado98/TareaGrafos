using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafoND
{
    public class Arista : Nodo
    {
        private Arista verticeA;
        private Arista verticeB;
        private int peso;

        public Arista(int pdato) : base(pdato)
        {
            verticeA = null;
            verticeB = null;
            peso = 0;
        }

    }
}
