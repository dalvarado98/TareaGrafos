using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafoND
{
   public class Vertice:Nodo
   {
       public Vertice siguienteVertice { get; set; }
       public Lista Lpredecesores { get; set; }
       public Lista Lsucesores { get; set; }

        public Vertice(int pdato) : base(pdato)
       {
           siguienteVertice = null;
           Lpredecesores = null;
           Lsucesores = null;

       }

}
}
