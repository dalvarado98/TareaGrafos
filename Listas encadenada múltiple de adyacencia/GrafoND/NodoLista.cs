﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafoND
{
    public class NodoLista : Nodo
    {
       
        public NodoLista anterior { get; set; }


        public NodoLista(int pdato) : base(pdato)
        {
            anterior = null;
        }
    }
}
