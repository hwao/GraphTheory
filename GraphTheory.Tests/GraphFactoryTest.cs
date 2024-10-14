using GraphTheory;

namespace GraphTheory.Tests;

[TestFixture]
[TestOf(typeof(GraphFactory))]
public class GraphFactoryTest
{

    [Test]
    public void testExampleGraph()
    {
        Graph exampleGraph = GraphFactory.CreateExampleGraph();
        
        Assert.That(exampleGraph.NumNodes, Is.EqualTo(5));
        Assert.That(exampleGraph.Edges.Count, Is.EqualTo(exampleGraph.NumNodes));
        
        Assert.That(exampleGraph.Edges[0].Count, Is.EqualTo(2)); // to 1, 2
        Assert.That(exampleGraph.Edges[1].Count, Is.EqualTo(2)); // to 2, 3
        Assert.That(exampleGraph.Edges[2].Count, Is.EqualTo(2)); // to 3, 2
        Assert.That(exampleGraph.Edges[3].Count, Is.EqualTo(0)); // it doesn't lead anywhere, but it is indicated twice
        Assert.That(exampleGraph.Edges[4].Count, Is.EqualTo(0)); // it doesn't lead anywhere and nothing indicates it
    }
}