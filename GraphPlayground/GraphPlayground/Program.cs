using System;

namespace GraphPlayground
{
    internal class Program
    {
        public static void DFS(Graph graph, Node startNode, Node targetNode = null)
        {
            Node currentNode = startNode;
            startNode.visited = true;
            Console.WriteLine("zacinam v uzlu " + startNode.index);
            while (true)
            {
                Console.Write("jsem v uzlu ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(currentNode.index);
                Console.ForegroundColor= ConsoleColor.White;
                Node NeighborToVisit = null;
                foreach(Node neighbor in currentNode.neighbors)
                {
                    if (!neighbor.visited)
                    {
                        NeighborToVisit = neighbor;
                    }
                }
                if (NeighborToVisit==null)
                {
                    if (currentNode == startNode)
                    {
                        Console.WriteLine("jsem ve startu nemam koho navstivit. konec");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("jsem ve slepe ulicce, jdu do " + currentNode.cameFrom.index);
                        currentNode = currentNode.cameFrom;
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("pokracuju do uzlu " + NeighborToVisit.index);
                    NeighborToVisit.visited = true;
                    NeighborToVisit.cameFrom = currentNode;
                    currentNode = NeighborToVisit;
                }
            }
        }

        public static void BFS(Graph graph, Node startNode, Node targetNode = null) 
        {
            
        }

        static void Main(string[] args)
        {
            //Create and print the graph
            Graph graph = new Graph();
            graph.PrintGraph();
            graph.PrintGraphForVisualization();

            //Call both algorithms with a random starting node
            Random rng = new Random();
            DFS(graph, graph.nodes[rng.Next(0, graph.nodes.Count)]);
            BFS(graph, graph.nodes[rng.Next(0, graph.nodes.Count)]);

            Console.ReadKey();
        }
    }
}
