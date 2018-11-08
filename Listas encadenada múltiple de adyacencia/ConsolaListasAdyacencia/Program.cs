using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaListasAdyacencia
{
    class Program
    {
       public static GrafoND.GrafoND GrafoND = new GrafoND.GrafoND();
        static void Main(string[] args)
        {
            GrafoND.insertarVertice(1);
            GrafoND.insertarVertice(2);
            GrafoND.insertarVertice(3);
            GrafoND.insertarVertice(4);

        }
    }
}
