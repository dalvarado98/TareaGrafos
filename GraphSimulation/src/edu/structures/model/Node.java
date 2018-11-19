package edu.structures.model;
import java.util.ArrayList;

public class Node<T> 
{
    
    private T info;
    private ArrayList<Node> neighbors;
    private Node prev;
    private boolean isVisit;
    
    public Node(T info) {
        this.info = info;
        this.neighbors = new ArrayList<Node>();
        this.isVisit = false;
        this.prev = null;
    }
    
    public T getInfo() {
        return info;
    }

    public ArrayList<Node> getNeighbors() {
        return neighbors;
    }

    public Node getPrev() {
        return prev;
    }

    public boolean getVisit() {
        return isVisit;
    }

    public void setInfo(T info) {
        this.info = info;
    }

    public void setNeighbors(ArrayList<Node> vec) {
        this.neighbors = vec;
    }

    public void setPrev(Node predecesor) {
        this.prev = predecesor;
    }
 
    public void setVisit(boolean esVisit) {
        this.isVisit = esVisit;
    }

    public boolean equals(Node v){
        return (this.info.equals(v.getInfo()));
    }
 
    public void insertNeighbor(Node v){
        this.neighbors.add(v);
    }
 
    public void removeNeighbor(Node v){
        ArrayList<Node> l = new ArrayList<Node>();
        for(Node vert: this.neighbors){
            if(!vert.equals(v))
                l.add(vert);
        }
        this.neighbors = l;
    }

    public boolean isAdjacent(Node v){
        for(Node vert: this.neighbors)
            if(vert.getInfo().equals(v.getInfo()))
                return (true);
        return (false);
    }

    public boolean isIsolated() {
        for(Node v: this.neighbors){
            if(!v.equals(this))
                return (false);
        }
        return (true);
    }

    public boolean isLeaf(){
        int i=0;
        for(Node v: this.neighbors){
            if(!v.equals(this)){
                if(++i>1)
                    return (false);
            }                
        }
        return (i==1);
    }
 
    public int getDegree() {
        return (this.neighbors.size());
    }

    @Override
    public String toString(){
        return (this.info.toString());
    }

}
