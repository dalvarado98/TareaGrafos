using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafoND
{
   public class Vertice
   {
       private int Dato;
       private List<Vertice> Lsucesores;
       private List<Vertice> Lpredecesores;

        public Vertice(int pDato)
        {
            Dato = pDato;
            Lsucesores = new List<Vertice>();
            Lpredecesores = new List<Vertice>();
        }
    }
}
