using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafoND
{
   public interface IGrafos
   {
      void insertarVertice(string pdatoVertice);
      void insertarArco(Vertice puntoA,Vertice puntoB, int peso);

   }
}
