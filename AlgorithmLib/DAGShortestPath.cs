using System.Runtime.CompilerServices;

namespace AlgorithmLib;


public static class DAGShortestPath
{
    public static (List<int>, List<int>) ShortestPath(Graph g, int startVertex)
    {
        // ADD CODE HERE AND FIX RETURN STATEMENT
        // call topo sort class
        List<int> sorted = DAGTopologicalSort.Sort(g);

        // make lists for the shortest and predecessor
        List<int> shortest = new List<int>(new int[g.Size()]);
        List<int> pred = new List<int>(new int[g.Size()]);
        
        // set lists to infinity
        for (int i = 0; i < g.Size(); i++)
        {
            shortest[i] = int.MaxValue; 
            pred[i] = int.MaxValue;     
        }

        // set starting vertex
        shortest[startVertex] = 0;
        
        foreach (int vertex in sorted)
        {
            if (shortest[vertex] != int.MaxValue)
            {
                // relax edges
                foreach (Edge edge in g.Edges(vertex))
                {
                    if (shortest[vertex] + edge.Weight < shortest[edge.DestId])
                    {
                        // change distance
                        shortest[edge.DestId] = shortest[vertex] + edge.Weight;
                        // change predecessor
                        pred[edge.DestId] = vertex;
                    }
                }
            }
        }

        return (shortest, pred);
    }


}