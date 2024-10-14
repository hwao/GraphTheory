namespace GraphTheory.Draw;

public class Terminal
{
    public static void PrintGraph(Graph graph)
    {
        foreach (KeyValuePair<int, List<Graph.Edge>> list in graph.Edges)
        {
            foreach (Graph.Edge edge in list.Value)
            {
                Console.WriteLine("+Key = {0}, Value = {1},{2}",
                    list.Key, edge.from, edge.to);
            }
        }
    }
}