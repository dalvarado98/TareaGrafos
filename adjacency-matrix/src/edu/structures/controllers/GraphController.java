package edu.structures.controllers;

import edu.structures.models.Graph;

public class GraphController {
    private Graph g;

    public GraphController(int vertices){
        g = new Graph(vertices);
        g.setVertices(vertices);
    }

    public int getEdge(int to, int from) {
        try
        {
            return g.getAdjacencyMatrix()[to][from];
        }
        catch (ArrayIndexOutOfBoundsException index)
        {
           throw index;
        }
    }

    public boolean addEdge(int to, int from, int edge){
        try
        {
            g.getAdjacencyMatrix()[to][from] = edge;
            g.getAdjacencyMatrix()[from][to] = edge;
        }
        catch (ArrayIndexOutOfBoundsException index)
        {
            return false;
        }
        return true;
    }

    public int getTotalVertices(){
       return g.getVertices();
    }

}
