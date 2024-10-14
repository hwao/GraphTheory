// See https://aka.ms/new-console-template for more information


// Starting DFS at node zero
/*
int start_node = 0;

DFS dfs = new DFS();
dfs.dfs(start_node);
*/

using System.Diagnostics;
using GraphTheory;
using GraphTheory.Algorithm;
using GraphTheory.Draw;

// Graph exampleGraph = GraphFactory.CreateExampleGraph();
Graph exampleGraph = GraphFactory.CreateExampleGraph02();

// Terminal.PrintGraph(exampleGraph);
// Mermaid.PrintGraph(exampleGraph);
// EdgeListDraw.PrintGraph(exampleGraph);
GraphvizDraw.PrintGraph(exampleGraph, true);

DFS dfs = new(exampleGraph);
int nodeCount = dfs.dfs(0);
Console.WriteLine("DFS node count starting at node 0: " + nodeCount);

nodeCount = dfs.dfs(4);
Console.WriteLine("DFS node count starting at node 4: " + nodeCount);

