using System.Security.Cryptography;

namespace AlgorithmLib;

public static class DijkstraShortestPath
{

     public static (List<int>, List<int>) ShortestPath(Graph g, int startVertex)
     {
//         // ADD CODE HERE AND FIX RETURN STATEMENT
//         // make lists for the shortest and predecessor
         List<int> shortest = new List<int>(new int[g.Size()]);
         List<int> pred = new List<int>(new int[g.Size()]);
//
//         // make a new empty priority queue
//         var Q = new PriorityQueue<int>();
//
//         // set shortest list to infinity and pred to null
//         for (int i = 0; i < g.Size(); i++)
//         {
//             shortest[i] = int.MaxValue;
//             pred[i] = -1;
//         }
//         // set shortest start vertex to 0
//         shortest[startVertex] = 0;
//
//         // insert vertices
//         for (var vertex = 0; vertex < g.Size(); vertex++)
//         {
//             Q.Insert(vertex, shortest[vertex]);
//         }
//
//         while (Q.Size() > 0)
//         {
//             // extract min to hold the returned vertex
//             var min = Q.Dequeue();
//             
//             // relax edges
//             foreach (var edge in g.Edges(min))
//             {
//                 if (shortest[min] + edge.Weight < shortest[edge.DestId])
//                 {
//                     // != int.MaxValue && shortest[min] 
//                     shortest[edge.DestId] = shortest[min] + edge.Weight;
//                     pred[edge.DestId] = min;
//                     Q.DecreaseKey(edge.DestId, shortest[edge.DestId]);
//                 }
//             }
//             
//         }
//
         return (shortest, pred);

     } 
}