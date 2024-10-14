namespace GraphTheory.Algorithm;

/**
 * Depth First Search
 * https://youtu.be/7fujbpJ0LB4?list=PLDV1Zeh2NRsDGO4--qE8yH72HFL1Km93P
 */
public class DFS
{
    public int n { get; private set; } // number of nodes
    private Graph graph; // g = list representing graph
    public int NumComponent { get; private set; }

    private int[] _components;
    private bool[] _visided; // [ false, false... false ]; // size n

    public DFS(Graph graph)
    {
        this.graph = graph;
        this.n = graph.NumNodes;
        this.NumComponent = 0;

        this.init();
    }

    private void init()
    {
        _visided = Enumerable.Repeat<bool>(false, this.n).ToArray();
        _components = Enumerable.Repeat<int>(0, this.n).ToArray();
    }

    public (int num, int[] list) FindComponents()
    {
        for (int i = 0; i < n; i++)
        {
            if (!_visided[i])
            {
                this.NumComponent++;
                dfs(i);
            }
        }

        return (NumComponent, this._components);
    }

    public int dfs(int at)
    {
        if (_visided[at]) return 0;

        _visided[at] = true;
        _components[at] = this.NumComponent;

        int nodeCount = 1;

        var neighbours = graph.Edges[at];
        foreach (Graph.Edge next in neighbours)
        {
            nodeCount += this.dfs(next.to);
        }

        return nodeCount;
    }
}