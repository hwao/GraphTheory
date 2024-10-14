using GraphTheory.Algorithm;

namespace GraphTheory.Tests.Algorithm;

[TestFixture]
[TestOf(typeof(DFS))]
public class DFSTest
{
    [Test]
    public void testDFS()
    {
        Graph exampleGraph = GraphFactory.CreateExampleGraph();

        DFS dfs = new(exampleGraph);

        Assert.That(dfs.dfs(0), Is.EqualTo(4), "DFS node count starting at node 0");
        Assert.That(dfs.dfs(4), Is.EqualTo(1), "DFS node count starting at node 4");
    }

    [Test]
    public void testFindComponents()
    {
        Graph exampleGraph = GraphFactory.CreateExampleGraph();

        DFS dfs = new(exampleGraph);
        var componentsInfo = dfs.FindComponents();

        Assert.That(componentsInfo.num, Is.EqualTo(2));
        Assert.That(componentsInfo.list[0], Is.EqualTo(1));
        Assert.That(componentsInfo.list[1], Is.EqualTo(1));
        Assert.That(componentsInfo.list[2], Is.EqualTo(1));
        Assert.That(componentsInfo.list[3], Is.EqualTo(1));
        Assert.That(componentsInfo.list[4], Is.EqualTo(2));
    }
}