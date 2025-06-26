namespace AlgorithmLib;

public static class BellmanFordShortestPath
{
    public static (List<int>, List<int>) ShortestPath(Graph g, int startVertex)
    {
        //make lists for the shortest and predecessor
        List<int> shortest = new List<int>(new int[g.Size()]);
        List<int> pred = new List<int>(new int[g.Size()]);
        
        
        // set shortest and predecessor lists to infinity 
        for (var i = 0; i < g.Size(); i++)
        {
            shortest[i] = int.MaxValue;
            pred[i] = int.MaxValue;
        }
        
        //set distance at start to 0
        shortest[startVertex] = 0;
        
        // for each edge in E
        for (var i = 0; i < g.Size(); i++)
        {
            bool changesMade = false;
            // relax edges
            for (var node = 0; node < g.Size(); node++)
            {
                foreach (var edge in g.Edges(node))
                {
                    if (shortest[node] + edge.Weight < shortest[edge.DestId])
                    {
                        // find if the graph has negative weight cycle
                        if (i == g.Size() - 1)
                        {
                            var cycle = FindNegativeWeight(g, pred, edge.DestId);
                            // return empty lists if the input graph has a negative cycle
                            return (new List<int>(), new List<int>());
                        }

                        changesMade = true;
                        shortest[edge.DestId] = shortest[node] + edge.Weight;
                        pred[edge.DestId] = node;
                    }
                }
            }

            if (changesMade == false)
            {
                break;
            }
        }
        
        return (shortest, pred);

    }

    // new function to find the negative weight cycles
    public static List<int> FindNegativeWeight(Graph g, List<int> pred, int vertex)
    {
        // create variables to visit vertices
        bool[] visited = new bool[g.Size()];
        int x = vertex;

        // follow predecessors
        while (visited[x] == false)
        {
            visited[x] = true;
            x = pred[x];
        }

        var v = pred[x];
        
        // list cycle
        List<int> cycle = new List<int>();
        cycle.Add(x);

        // insert into cycle
        while (v != x)
        {
            cycle.Insert(0, v);
            v = pred[v];
        }

        return cycle;
    }
    
}
