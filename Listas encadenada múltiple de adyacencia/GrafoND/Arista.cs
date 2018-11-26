using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafoND
{
    public class Arista 
    {
        public Vertice PuntoA { get; set; }
        public Arista arcoPredecesor { get; set; }
        public Arista arcoSucesor { get; set; }
        public Vertice puntoB { get; set; }
        public int peso { get; set; }

        public Arista(Vertice pPuntoA, Vertice pPuntoB, int pPeso)
        {
            PuntoA = pPuntoA;
            puntoB = pPuntoB;
            peso = pPeso;
        }
    }
}
