﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafoND
{
   public class GrafoND
   {
       
       private Vertice Cabecera;
       private Vertice Ultimo;

        public GrafoND()
        {
            
            Cabecera = null;
            Ultimo = null;
        }

       public void InsertarVertice(int pdatoVertice)
       {

            Vertice NuevoVertice = new Vertice(pdatoVertice);
           if (Cabecera != null)
           {
               Ultimo.siguienteVertice = NuevoVertice;
               NuevoVertice.siguienteVertice = null;
               Ultimo = NuevoVertice;
           }
           else
           {
               Cabecera = NuevoVertice;
               Cabecera.siguienteVertice = null;
               Ultimo = NuevoVertice;


           }
        }

    }
}
