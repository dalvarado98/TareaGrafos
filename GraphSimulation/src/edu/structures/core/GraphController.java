/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package edu.structures.core;

import edu.structures.model.Graph;
import java.util.Scanner;

/**
 *
 * @author Daniel_Alvarado
 */
public class GraphController {

    private Graph graph;
    private Scanner sc = new Scanner(System.in);

    public GraphController() {
        this.graph = new Graph();
    }

    public boolean addNode() {
        System.out.println("Ingrese el número que desea ingresar");
        try {
            int nodeInfo = sc.nextInt();
            graph.insertNode(nodeInfo);
            return true;
        } catch (Exception ex) {
            System.out.println("Dato no valido");
            return false;
        }
    }

    public boolean addLinkToNodes() {

        try {
            System.out.println("**********************************");
            displayNodes();
            System.out.println("**********************************");
            System.out.println("Para ingresar un link entre dos nodos ingrese los datos que desea unir\nDato A: ");
            int firstNode = sc.nextInt();
            System.out.println("Dato B: ");
            int secondNode = sc.nextInt();
            return graph.insertLink(firstNode, secondNode);
        } catch (Exception ex) {
            System.out.println("Error con los datos ingresados");
            return false;
        }
    }

    public void displayNodes() {
        System.out.println("Información del grafo");
        System.out.println(graph.toString());
    }

}
