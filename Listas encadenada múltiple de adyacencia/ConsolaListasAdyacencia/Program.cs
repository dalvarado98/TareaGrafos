using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GrafoND;

namespace ConsolaListasAdyacencia
{
    class Program
    {
        public static GrafoND.ListaMultiGrafoDirigido GrafoN1 = new GrafoND.ListaMultiGrafoDirigido();
        public static GrafoND.ListaMultiGrafoDirigido GrafoN2 = new GrafoND.ListaMultiGrafoDirigido();

        static void Main(string[] args)
        {
            Console.WriteLine("LISTAS ENCADENADAS MULTIPLES DE ADYACENCIAS 1");
            Console.WriteLine("\nLISTA DE UNIONES");
            Console.WriteLine("De Z a F -> Peso 10");
            Console.WriteLine("De T a F -> Peso 20");
            Console.WriteLine("De T a M -> Peso 60");
            Console.WriteLine("\nLISTA DE ARCOS PREDECESORES Y SUCESORES PARA CADA VÉRTICE \n");

            GrafoN1.insertarVertice("Z");
            GrafoN1.insertarVertice("F");
            GrafoN1.insertarVertice("T");
            GrafoN1.insertarVertice("M");

            Vertice puntoA = new Vertice("Z");
            Vertice puntoB = new Vertice("F");
            Vertice puntoC = new Vertice("T");
            Vertice puntoD = new Vertice("M");

            int pesoAB = 10;
            int pesoCB = 20;
            int pesoCD = 60;

            GrafoN1.insertarArco(puntoA, puntoB, pesoAB);
            GrafoN1.insertarArco(puntoC, puntoB, pesoCB);
            GrafoN1.insertarArco(puntoC, puntoD, pesoCD);

            Console.WriteLine(GrafoN1.generarLista());

            Console.WriteLine("\nLISTAS ENCADENADAS MULTIPLES DE ADYACENCIAS 2\n");

            Console.WriteLine("LISTA DE UNIONES");
            Console.WriteLine("De VO a V1 -> Peso 1");
            Console.WriteLine("De V1 a V2 -> Peso 2");
            Console.WriteLine("De V2 a V3 -> Peso 3");
            Console.WriteLine("De V3 a V4 -> Peso 4");
            Console.WriteLine("De V4 a V5 -> Peso 5");
            Console.WriteLine("De V5 a V6 -> Peso 6");
            Console.WriteLine("De V6 a VO -> Peso 7");
            Console.WriteLine("De VO a V4 -> Peso 8");
            Console.WriteLine("De V2 a V6 -> Peso 9");
            Console.WriteLine("De V5 a V2 -> Peso 10");

            GrafoN2.insertarVertice("VO");
            GrafoN2.insertarVertice("V1");
            GrafoN2.insertarVertice("V2");
            GrafoN2.insertarVertice("V3");
            GrafoN2.insertarVertice("V4");
            GrafoN2.insertarVertice("V5");
            GrafoN2.insertarVertice("V6");

            Vertice VO = new Vertice("VO");
            Vertice V1 = new Vertice("V1");
            Vertice V2 = new Vertice("V2");
            Vertice V3 = new Vertice("V3");
            Vertice V4 = new Vertice("V4");
            Vertice V5 = new Vertice("V5");
            Vertice V6 = new Vertice("V6");

            int peso1 = 1;
            int peso2 = 2;
            int peso3 = 3;
            int peso4 = 4;
            int peso5 = 5;
            int peso6 = 6;
            int peso7 = 7;
            int peso8 = 8;
            int peso9 = 9;
            int peso10 = 10;

            GrafoN2.insertarArco(VO, V1, peso1);
            GrafoN2.insertarArco(V1, V2, peso2);
            GrafoN2.insertarArco(V2, V3, peso3);
            GrafoN2.insertarArco(V3, V4, peso4);
            GrafoN2.insertarArco(V4, V5, peso5);
            GrafoN2.insertarArco(V5, V6, peso6);
            GrafoN2.insertarArco(V6, VO, peso7);
            GrafoN2.insertarArco(VO, V4, peso8);
            GrafoN2.insertarArco(V2, V6, peso9);
            GrafoN2.insertarArco(V5, V2, peso10);

            Console.WriteLine("\n" + GrafoN2.generarLista());

            Console.Write("Salir? Presione cualquier tecla ");
            string respuesta = Console.ReadLine();
        }
    }
}
