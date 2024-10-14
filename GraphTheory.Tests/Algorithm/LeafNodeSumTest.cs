using GraphTheory.Algorithm;
using NuGet.Frameworks;

namespace GraphTheory.Tests.Algorithm;

[TestFixture]
[TestOf(typeof(LeafNodeSum))]
public class LeafNodeSumTest
{
    [Test]
    public void METHOD()
    {
        Graph exampleGraph = GraphFactory.CreateExampleGraph02();

        LeafNodeSum leafNodeSum = new(exampleGraph);

        int result = leafNodeSum.Solve(0);

        Assert.That(result, Is.EqualTo(9));
    }
}