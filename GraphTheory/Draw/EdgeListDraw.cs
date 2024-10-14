namespace GraphTheory.Draw;

public class EdgeListDraw
{
    public static void PrintGraph(Graph graph)
    {
        // https://graphonline.ru/en/create_graph_by_edge_list

        foreach (KeyValuePair<int, List<Graph.Edge>> list in graph.Edges)
        {
            foreach (Graph.Edge edge in list.Value)
            {
                Console.WriteLine("{0}>{1}", edge.from, edge.to);
            }
        }
    }
}