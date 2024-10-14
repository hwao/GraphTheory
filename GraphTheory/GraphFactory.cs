namespace GraphTheory;

public class GraphFactory
{
    public static Graph CreateExampleGraph()
    {
        // Create a fully connected graph
        //           (0)
        //           / \
        //        5 /   \ 4
        //         /     \
        // 10     <   -2  >
        //   +->(2)<------(1)      (4)
        //   +--- \       /
        //         \     /
        //        1 \   / 6
        //           > <
        //           (3)
        // https://mermaid.live/edit#pako:eNptkL0KwzAMhF8laHagcTt56NS1U7fiRcTKD8R2cORACXn3ummKIVST9N0JdFqg9oZAwcTIdOuxDWjLWWpX7HUqyvJaVEeQHVmpNuWcgfwP5HElgYwu2oEAS8Fib9Jly0fSwB1Z0qBSa6jBOLAG7dZkxcj-8XI1KA6RBAQf2w5Ug8OUpjianOxnIdOzD_dv9O0DAkZ0T-93y_oGpMhMXg

        int numNodes = 5;

        Graph graph = new(numNodes);
        graph.AddDirectedEdge(0, 1, 4);
        graph.AddDirectedEdge(0, 2, 5);
        graph.AddDirectedEdge(1, 2, -2);
        graph.AddDirectedEdge(1, 3, 6);
        graph.AddDirectedEdge(2, 3, 1);
        graph.AddDirectedEdge(2, 2, 10); // Self loop

        return graph;
    }

    public static Graph CreateExampleGraphForBFS()
    {
        int numNodes = 13;

        Graph graph = new(numNodes);
        graph.AddUnweightedUndirectedEdge(0, 7);
        graph.AddUnweightedUndirectedEdge(0, 9);
        graph.AddUnweightedUndirectedEdge(0, 11);
        graph.AddUnweightedUndirectedEdge(7, 11);
        graph.AddUnweightedUndirectedEdge(7, 6);
        graph.AddUnweightedUndirectedEdge(7, 3);
        graph.AddUnweightedUndirectedEdge(6, 5);
        graph.AddUnweightedUndirectedEdge(3, 4);
        graph.AddUnweightedUndirectedEdge(2, 3);
        graph.AddUnweightedUndirectedEdge(2, 12);
        graph.AddUnweightedUndirectedEdge(12, 8);
        graph.AddUnweightedUndirectedEdge(8, 1);
        graph.AddUnweightedUndirectedEdge(1, 10);
        graph.AddUnweightedUndirectedEdge(10, 9);
        graph.AddUnweightedUndirectedEdge(9, 8);

        return graph;
    }

    public static Graph CreateExampleGraph02()
    {
        // https://magjac.com/graphviz-visual-editor/?dot=digraph%20%7B%0A%090-%3E1%20%5Blabel%20%3D%20%224%22%5D%3B%0A%090-%3E6%20%5Blabel%20%3D%20%223%22%5D%3B%0A%091-%3E2%20%5Blabel%20%3D%20%221%22%5D%3B%0A%091-%3E3%20%5Blabel%20%3D%20%22-6%22%5D%3B%0A%092-%3E4%20%5Blabel%20%3D%20%222%22%5D%3B%0A%092-%3E5%20%5Blabel%20%3D%20%229%22%5D%3B%0A%096-%3E7%20%5Blabel%20%3D%20%220%22%5D%3B%0A%096-%3E8%20%5Blabel%20%3D%20%227%22%5D%3B%0A%096-%3E9%20%5Blabel%20%3D%20%22-4%22%5D%3B%0A%098-%3E10%20%5Blabel%20%3D%20%228%22%5D%3B%0A%7D
        int numNodes = 11;

        Graph graph = new(numNodes);
        graph.AddDirectedEdge(0, 1, 4);
        graph.AddDirectedEdge(1, 2, 1);
        graph.AddDirectedEdge(1, 3, -6);
        graph.AddDirectedEdge(2, 4, 2);
        graph.AddDirectedEdge(2, 5, 9);
        graph.AddDirectedEdge(0, 6, 3);
        graph.AddDirectedEdge(6, 7, 0);
        graph.AddDirectedEdge(6, 8, 7);
        graph.AddDirectedEdge(6, 9, -4);
        graph.AddDirectedEdge(8, 10, 8);


        return graph;
    }
}