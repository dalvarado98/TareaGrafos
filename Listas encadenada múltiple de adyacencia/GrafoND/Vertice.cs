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
       public Arista arcoPredecesor { get; set; }
       public Arista arcoSucesor { get; set; }
       public bool EsSucesor { get; set; }
       public bool EsVisit { get; set; }




        public Vertice(String pdato) : base(pdato)
       {
           siguienteVertice = null;
            arcoPredecesor = null;
            arcoSucesor = null;
           EsSucesor = false;
           EsVisit = false;
       }

       public Vertice( string pdato, bool esSucesor) : base(pdato)
        {
           Dato = pdato;
            EsSucesor = esSucesor;


        }

}
}
