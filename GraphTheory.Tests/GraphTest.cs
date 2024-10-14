using GraphTheory;

namespace GraphTheory.Tests;

[TestFixture]
[TestOf(typeof(Graph))]
public class GraphTest
{
    [Test]
    public void testGraphMethods()
    {
        Graph graph = new(3);

        Assert.That(graph.NumNodes, Is.EqualTo(3));

        Assert.That(graph.Edges[0].Count, Is.EqualTo(0));
        Assert.That(graph.Edges[1].Count, Is.EqualTo(0));
        Assert.That(graph.Edges[2].Count, Is.EqualTo(0));
        
        graph.AddDirectedEdge(0, 1, 2);
        Assert.That(graph.Edges[0].Count, Is.EqualTo(1));

        Assert.Throws<KeyNotFoundException>(
            () => graph.AddDirectedEdge(3, 0, 2));
        
        Assert.Throws<ArgumentException>(
            () => graph.AddDirectedEdge(0, 3, 2));
    }
}