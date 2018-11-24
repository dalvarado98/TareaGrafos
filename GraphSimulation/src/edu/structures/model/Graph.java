package edu.structures.model;
import java.util.ArrayList;
import java.util.LinkedList;
import java.util.Queue;

public class Graph<T> 
{
    private ArrayList<Node> Nodes;
    private ArrayList<Link> links;

    public Graph() {
        this.Nodes = new ArrayList<Node>();
        this.links = new ArrayList<Link>();
    }

    public ArrayList<Node> getNodes() {
        return Nodes;
    }

    public ArrayList<Link> getLinks() {
        return links;
    } 

    public void setNodes(ArrayList<Node> l) {
        this.Nodes = l;
    }

    public void setLinks(ArrayList<Link> l) {
        this.links = l;
    }

    public boolean insertNode(T info){
        Node v = new Node(info);
        if(contains((T) v.getInfo()))
            return (false);
        this.Nodes.add(v);        
        return (true);
    }

    public boolean insertLink(T info1, T info2){
        Node<T> a = this.searchNode(info1);
        Node<T> b = this.searchNode(info2);
        if(a==null || b==null)
            return (false);
        a.insertNeighbor(b);
        if(!a.equals(b))
            b.insertNeighbor(a);
        this.links.add(new Link<T>(a,b,-1));
        return (true);
    }

    public Node<T> searchNode(T info){
        for(Node v: this.Nodes){
            if(v.getInfo().equals(info))
                return (v);
        }
        return (null);
    }

    public Link<T> searchLink(T info1, T info2){
        for(Link a : this.links){
            if(a.equalsNotDirect(new Link(new Node(info1),new Node(info2),-1)))
                return (a);
        }
        return (null);
    }

    public boolean contains(T x){
        for(Node v: this.Nodes){
            if(v.getInfo().equals(x))
                return (true);
        }
        return (false);
    }

    @Override
    public String toString(){
        String cad = "Nodes: ";
        for(Node v:this.Nodes){
            cad+=v.getInfo()+",";
        }
        cad+="\nLinks:";
        for(Link a:this.links){
            cad+=a.toString()+",";
        }
        return (cad);
    }
    
}
