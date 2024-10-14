using GraphTheory.Algorithm;

namespace GraphTheory.Tests.Algorithm;

[TestFixture]
[TestOf(typeof(BFS))]
public class BFSTest
{
    [Test]
    public void METHOD()
    {
        Graph exampleGraph = GraphFactory.CreateExampleGraphForBFS();

        BFS bfs = new BFS(exampleGraph);

        int[] path = bfs.Bfs(10, 5);

        // [10 -> 9 -> 0 -> 7 -> 6 -> 5]
        Assert.That(path[0], Is.EqualTo(10));
        Assert.That(path[1], Is.EqualTo(9));
        Assert.That(path[2], Is.EqualTo(0));
        Assert.That(path[3], Is.EqualTo(7));
        Assert.That(path[4], Is.EqualTo(6));
        Assert.That(path[5], Is.EqualTo(5));
    }
}