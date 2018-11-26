using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafoND
{
   public class ListaMultiGrafoDirigido:IGrafos
   {

        private Vertice Cabecera;
        private Vertice Ultimo;

        public ListaMultiGrafoDirigido()
        {
            Cabecera = null;
            Ultimo = null;
        }

        public void insertarVertice(string pdatoVertice)
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

        public void insertarArco(Vertice puntoA, Vertice puntoB, int peso)
        {
            Vertice verticeSucesor = null;
            Vertice verticePredecesor = null;
            Arista arista = new Arista(puntoA, puntoB, peso);
            bool encontrado = false;

            verticePredecesor = Cabecera;
            verticeSucesor = Cabecera;

            while (verticePredecesor.siguienteVertice != null && !encontrado)
            {
                if (verticePredecesor.Dato == puntoA.Dato)
                {
                    encontrado = true;
                }
                else
                {
                    verticePredecesor = verticePredecesor.siguienteVertice;
                }
            }

            encontrado = false;

            while (verticeSucesor.siguienteVertice != null && !encontrado)
            {
                if (verticeSucesor.Dato == puntoB.Dato)
                {
                    encontrado = true;
                }
                else
                {
                    verticeSucesor = verticeSucesor.siguienteVertice;
                }
            }

            insertarArcos(verticePredecesor, verticeSucesor, arista);
        }

        public void insertarArcos(Vertice predecesor, Vertice sucesor, Arista nuevaArista)
        {
            insertarArcoSucesor(predecesor, nuevaArista);
            insertarArcoPredecesor(sucesor, nuevaArista);
        }

        public void insertarArcoPredecesor(Vertice vertice, Arista nuevoArcoPredecesor)
        {
            Arista aux = null;

            if (vertice.arcoPredecesor != null)
            {
                aux = vertice.arcoPredecesor;

                while (aux.arcoPredecesor != null)
                {
                    aux = aux.arcoPredecesor;

                }

                aux.arcoPredecesor = nuevoArcoPredecesor;
            }
            else
            {
                vertice.arcoPredecesor = nuevoArcoPredecesor;
            }
        }

        public void insertarArcoSucesor(Vertice vertice, Arista nuevoArcoSucesor)
        {
            Arista aux = null;


            if (vertice.arcoSucesor != null)
            {
                aux = vertice.arcoSucesor;

                while (aux.arcoSucesor != null)
                {
                    aux = aux.arcoSucesor.arcoSucesor;

                }

                aux.arcoSucesor = nuevoArcoSucesor;
            }
            else
            {
                vertice.arcoSucesor = nuevoArcoSucesor;
            }
        }

        public string generarLista()
        {
            string lista = "";
            Vertice aux = Cabecera;

            while (aux != null)
            {
                lista = lista + obtenerAntecesores(aux) + " <-- Antecesores -- Vertice:" + aux.Dato + " -- Sucesores --> " + obtenerListaSucesores(aux) + "\n\n";
                aux = aux.siguienteVertice;
            }

            return lista;
        }

        public string obtenerAntecesores(Vertice vertice)
        {
            string listaAntecesores = "";
            Arista arcoAux = vertice.arcoPredecesor;

            while (arcoAux != null)
            {
                listaAntecesores = listaAntecesores + " < " + arcoAux.peso;
                arcoAux = arcoAux.arcoPredecesor;
            }

            return listaAntecesores;
        }

        public string obtenerListaSucesores(Vertice vertice)
        {
            string listaSucesores = "";
            Arista arcoAux = vertice.arcoSucesor;

            while (arcoAux != null)
            {
                listaSucesores = listaSucesores + arcoAux.peso + " > ";
                arcoAux = arcoAux.arcoSucesor;
            }

            return listaSucesores;
        }
    }
}
