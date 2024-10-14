using System.Numerics;

namespace GraphTheory.Algorithm;

/**
 * Breadth First Search
 * https://youtu.be/oDqjPvD54Ss?list=PLDV1Zeh2NRsDGO4--qE8yH72HFL1Km93P
 * O(V+E) Vertices + Edges
 */
public class BFS
{
    public int n { get; private set; } // number of nodes
    private Graph graph; // g = list representing graph

    public BFS(Graph graph)
    {
        this.graph = graph;
        this.n = graph.NumNodes;
    }

    public int[] Bfs(int start, int end)
    {
        var path = this.Solve(start);

        return ReconstructPath(start, end, path);
    }

    private int?[] Solve(int start)
    {
        int?[] prev = new int?[this.n];
        bool[] visided = Enumerable.Repeat<bool>(false, this.n).ToArray();
        Queue<int> queue = new();

        queue.Enqueue(start);
        visided[start] = true;

        while (queue.Any())
        {
            int numNode = queue.Dequeue();
            var neighbours = graph.Edges[numNode];

            foreach (Graph.Edge edge in neighbours)
            {
                if (!visided[edge.to])
                {
                    visided[edge.to] = true;
                    prev[edge.to] = numNode;
                    queue.Enqueue(edge.to);
                }
            }
        }

        return prev;
    }

    private int[] ReconstructPath(int start, int end, int?[] prev)
    {
        List<int> path = new List<int>();

        for (int? at = end; at != null; at = prev[(int)at])
        {
            path.Add((int)at);
        }

        path.Reverse();

        if (path[0] != start) path.Clear();

        return path.ToArray();
    }
}