using GraphTheory.Algorithm;

namespace GraphTheory.Tests.Algorithm;

[TestFixture]
[TestOf(typeof(RootTree))]
public class RootTreeTest
{
    [Test]
    public void rootingTree()
    {
        Graph exampleGraph = GraphFactory.CreateExampleGraph02();

        RootTree rootTree = new();
        TreeNode rootNode = rootTree.Solve(exampleGraph, 0);

        Assert.That(rootNode.Id, Is.EqualTo(0));
        Assert.That(rootNode.Children.Count, Is.EqualTo(2));
        Assert.That(rootNode.Parent, Is.Null);

        {
            Assert.That(rootNode.Children[0].Id, Is.EqualTo(1));
            Assert.That(rootNode.Children[0].Parent, Is.EqualTo(rootNode));
            Assert.That(rootNode.Children[0].Children.Count, Is.EqualTo(2));
            {
                Assert.That(rootNode.Children[0].Children[0].Id, Is.EqualTo(2));
                Assert.That(rootNode.Children[0].Children[0].Children.Count, Is.EqualTo(2));
                {
                    Assert.That(rootNode.Children[0].Children[0].Children[0].Id, Is.EqualTo(4));
                    Assert.That(rootNode.Children[0].Children[0].Children[0].Children.Count, Is.EqualTo(0));
                }
            }
            
            Assert.That(rootNode.Children[1].Id, Is.EqualTo(6));
            Assert.That(rootNode.Children[1].Parent, Is.EqualTo(rootNode));
            Assert.That(rootNode.Children[1].Children.Count, Is.EqualTo(3));
            {
                Assert.That(rootNode.Children[1].Children[0].Id, Is.EqualTo(7));
                Assert.That(rootNode.Children[1].Children[0].Children.Count, Is.EqualTo(0));
            }
        }
    }
}