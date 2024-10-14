using Microsoft.VisualBasic.CompilerServices;

namespace GraphTheory.Algorithm;

public class RootTree
{
    public TreeNode Solve(Graph graph, int rootId = 0)
    {
        TreeNode root = new(rootId, null);
        return BuildTree(graph, root, null);
    }

    private TreeNode BuildTree(Graph graph, TreeNode node, TreeNode? parent)
    {
        foreach (var edge in graph.Edges[node.Id])
        {
            if (parent != null && edge.to == parent.Id)
            {
                continue;
            }

            TreeNode child = new(edge.to, node);
            node.Children.Add(child);

            BuildTree(graph, child, node);
        }

        return node;
    }
}