namespace GraphTheory;

public class TreeNode
{
    public int Id { get; private set; }

    public TreeNode? Parent { get; private set; }

    public List<TreeNode> Children { get; private set; } = new List<TreeNode>();

    public TreeNode(int nodeId, TreeNode? parent)
    {
        Id = nodeId;
        Parent = parent;
    }
}