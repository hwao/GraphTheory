namespace GraphTheory.Algorithm;

public class LeafNodeSum
{
    private Graph graph;

    public LeafNodeSum(Graph graph)
    {
        this.graph = graph;
    }

    public int Solve(int nodeId)
    {
        int sum = 0;

        foreach (Graph.Edge edge in graph.Edges[nodeId])
        {
            if (IsLeaf(edge))
            {
                sum += edge.cost;
            }
            else
            {
                sum += Solve(edge.to);
            }
        }

        return sum;
    }

    private bool IsLeaf(Graph.Edge edge)
    {
        return graph.Edges[edge.to].Count == 0;
    }
}