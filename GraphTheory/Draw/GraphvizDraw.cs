using System.Web;
using System.Text;

namespace GraphTheory.Draw;

public class GraphvizDraw
{
    private const string LAYOUT_CIRCO = "circo";
    private const string LAYOUT_DOT = "dot";
    private const string LAYOUT_NEATO = "neato";

    public static void PrintGraph(Graph graph, bool showCost = false)
    {
        // https://magjac.com/graphviz-visual-editor/

        StringBuilder myStringBuilder = new StringBuilder();

        myStringBuilder.Append("digraph {\n");
        myStringBuilder.AppendFormat("\tlayout={0}\n", LAYOUT_CIRCO);
        foreach (KeyValuePair<int, List<Graph.Edge>> list in graph.Edges)
        {
            foreach (Graph.Edge edge in list.Value)
            {
                myStringBuilder.Append($"\t{edge.from}->{edge.to}");
                if (showCost)
                {
                    myStringBuilder.Append($" [label = \"{edge.cost}\"]");
                }

                myStringBuilder.Append(";\n");
            }
        }

        myStringBuilder.Append("}");

        Console.WriteLine(CreateUrl(myStringBuilder));
    }

    private static string CreateUrl(StringBuilder allConsoleOutput)
    {
        return string.Format(
            "https://magjac.com/graphviz-visual-editor/?dot={0}",
            HttpUtility.UrlEncode(allConsoleOutput.ToString())
        );
    }
}