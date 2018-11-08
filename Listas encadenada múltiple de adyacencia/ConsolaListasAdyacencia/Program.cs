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
            GrafoND.InsertarVertice(1);
            GrafoND.InsertarVertice(2);
            GrafoND.InsertarVertice(3);
            GrafoND.InsertarVertice(4);

        }
    }
}
