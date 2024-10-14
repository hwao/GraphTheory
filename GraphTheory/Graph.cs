namespace GraphTheory;

public class Graph
{
    public class Edge
    {
        public int from, to, cost;

        public Edge(int from, int to, int cost)
        {
            this.from = from;
            this.to = to;
            this.cost = cost;
        }
    }

    public readonly int NumNodes;

    public Dictionary<Int32, List<Edge>> Edges;

    public Graph(int numNodes)
    {
        this.NumNodes = numNodes;
        this.Edges = new Dictionary<int, List<Edge>>();

        for (int i = 0; i < this.NumNodes; ++i)
        {
            this.Edges.Add(i, new List<Edge>());
        }
    }

    public void AddDirectedEdge(int from, int to, int cost = 1)
    {
        if (to >= this.NumNodes) throw new ArgumentException("Argument `to` out of bounds");

        this.Edges[from].Add(new Edge(from, to, cost));
    }

    public void AddUndirectedEdge(int from, int to, int cost)
    {
        AddDirectedEdge(from, to, cost);
        AddDirectedEdge(to, from, cost);
    }

    public void AddUnweightedUndirectedEdge(int from, int to)
    {
        AddUndirectedEdge(from, to, 1);
    }
}