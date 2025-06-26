using System.Collections;

namespace AlgorithmLib;

public static class DAGTopologicalSort
{
    public static List<int> Sort(Graph g)
    {
        // create new array and set the length to be the size of graph
        int[] in_degree = new int[g.Size()];

        // set all values in array to 0
        for (int i = 0; i < in_degree.Length; i++)
        {
            in_degree[i] = 0; 
        }
        
        // increment in_degree with edges
        for (int vertex = 0; vertex < g.Size(); vertex++)
        {
            foreach (Edge edge in g.Edges(vertex))
            {
                in_degree[edge.DestId]++;
            }
        }
        
        // create new list consisting of all vertices 
        List<int> next = new List<int>();
        // populate list such that in_degree[u] = 0
        for (var vertex = 0; vertex < g.Size(); vertex++)
        {
            if (in_degree[vertex] == 0)
            {
                next.Add(vertex);
            }
        }
        
        // create linear order list
        List<int> linear_order = new List<int>();
        
        // while next is not empty, do the following
        while (next.Count > 0)
        {
            // delete a vertex from next and call it vertex u
            var vertex_u = next[next.Count - 1];
            next.RemoveAt(next.Count - 1);
    
            // add u to the end of linear order
            linear_order.Add(vertex_u);
    
            // decrement in_degree, or if edge is 0, insert into next list
            foreach (Edge edge in g.Edges(vertex_u))
            {
                in_degree[edge.DestId]--;
                if (in_degree[edge.DestId] == 0)
                {
                    next.Add(edge.DestId);
                }
            }
        }
        
        return linear_order;
    } 
}
