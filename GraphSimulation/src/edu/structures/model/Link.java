/**
 * ---------------------------------------------------------------------
 * $Id: Arista.java,v 2.0 2013/08/23 
 * Universidad Francisco de Paula Santander 
 * Programa Ingenieria de Sistemas
 *
 * Proyecto: SEED_UFPS
 * ----------------------------------------------------------------------
 */

package edu.structures.model;

/**
 * Implementacion de la Clase para el manejo de las Aristas/Arcos del Grafo;
 Una Link corresponde a una relacion entre dos vertices de un Grafo.
 * @param <T> Tipo de objetos a almacenar dentro de la Link.
 * @author Uriel Garcia
 * @version 1.0
 */

public class Link<T> 
{
    
    private Node<T> nodeA;
    private Node<T> nodeB;
    private int weight;
    private boolean isVisit;
    
    public Link(Node<T> vA, Node<T> vB, int p) {
        this.nodeA = vA;
        this.nodeB = vB;
        this.weight = p;
        this.isVisit = false;
    }

    public Node<T> getNodeA() {
        return nodeA;
    }

    public void setNodeA(Node<T> vertA) {
        this.nodeA = vertA;
    }

    public Node<T> getNodeB() {
        return nodeB;
    }

    public void setNodeB(Node<T> vertB) {
        this.nodeB = vertB;
    }

    public int getWeight() {
        return weight;
    }

    public void setWeight(int peso) {
        this.weight = peso;
    }
    
    public boolean getVisit() {
        return isVisit;
    }

    public void setVisit(boolean esVisit) {
        this.isVisit = esVisit;
    }
    
    public boolean livesIn(Node v){
        return (this.nodeA.equals(v)||this.nodeB.equals(v));
    }
    
    public boolean equalsNotDirect(Link ar){
        return ((ar.getNodeA().equals(this.nodeA))||(ar.getNodeA().equals(this.nodeB)))&&
                ((ar.getNodeB().equals(this.nodeA))||(ar.getNodeB().equals(this.nodeB)));
    }
    
    public boolean equalsDirect(Link ar){
        return ((ar.getNodeA().equals(this.nodeA))&&(ar.getNodeB().equals(this.nodeB)));
    }
    
    @Override
    public String toString(){
        return ("("+this.nodeA.getInfo()+"-"+this.nodeB.getInfo()+")");
    }
}
