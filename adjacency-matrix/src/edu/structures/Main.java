package edu.structures;

import edu.structures.controllers.GraphController;

import java.util.Scanner;


public class Main {
    private static Scanner sc = new Scanner(System.in);
    private static GraphController graph;

    public static void main(String[] args) {
       addNumberVertices();
       menu();
    }

    private static void addNumberVertices(){
        int opt,numVertices;
        System.out.println("La matriz de adyacencia tiene 8 vertices por default");
        System.out.println("Desea cambiar el numero de vertices? \n1. Si\n2. No");
        opt = sc.nextInt();
        if (opt == 1){
            System.out.println("Digite el numero de vertices que desea: ");
            numVertices = sc.nextInt();
            graph = new GraphController(numVertices);
        }
        if(opt != 1){
            graph = new GraphController(8);
        }
    }

    private static void menu(){
        int option;
        do{
            System.out.println();
            System.out.println("Matriz de adyacencia");
            System.out.println("-------------------------\n");
            System.out.println("1 - Ver matriz\n2 - Agregar arco\n3 - Salir");
            option = sc.nextInt();
            handleMenu(option);
        }while (option != 3);

    }

    private static void handleMenu(int option){
        switch (option){
            case 1:
                displayMatrix();
                break;
            case 2:
                addEdge();
                break;
            case 3:
                System.exit(0);
            default:
                System.out.println("Invalido!");
                break;
        }
    }

    private static void displayMatrix() throws ArrayIndexOutOfBoundsException{
        int vertices = graph.getTotalVertices();

        System.out.print("  ");
        for (int i = 1; i <= vertices; i++) {
            System.out.print(i + " ");
        }
        System.out.println();

        for (int i = 1; i <= vertices; i++){
            System.out.print(i + " ");
            for (int j = 1; j <= vertices; j++) {
                System.out.print(graph.getEdge(i, j) + " ");
            }
            System.out.println();
        }
    }

    private static void addEdge(){
        int to,from;

        System.out.println("Para ingresar un arco entre dos vertices, ingrese los vertices que desea unir");
        System.out.println("Ingrese el vertice 1 : ");
        to = sc.nextInt();
        System.out.println("Ingrese el vertice 2 : ");
        from = sc.nextInt();

        boolean isCorrect = graph.addEdge(to, from, 1);
        if (isCorrect){
            System.out.println("Se agrego el arco del vertice " + to + " al vertice " + from );
        }else{
            System.out.println("Vertice invalido!!");
        }
    }
}
