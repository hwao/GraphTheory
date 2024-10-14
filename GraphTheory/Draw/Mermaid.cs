namespace GraphTheory.Draw;

public class Mermaid
{
    public static void PrintGraph(Graph graph)
    {
        // https://mermaid.js.org/syntax/stateDiagram.html

        Console.WriteLine("stateDiagram-v2");

        foreach (KeyValuePair<int, List<Graph.Edge>> list in graph.Edges)
        {
            foreach (Graph.Edge edge in list.Value)
            {
                Console.WriteLine("\t{0} --> {1}", edge.from, edge.to);
            }
        }
    }
}