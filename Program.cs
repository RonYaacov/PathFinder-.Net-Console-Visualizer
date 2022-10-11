using PathFinder;
using PathFinder.SearchMethods;

namespace ClientPathFinder
{
    class Program
    {
        public static void Main(string[] args)
        {
            var testBFS = new GridBFS();
            var testDFS = new GridDFS();
            Console.WriteLine("This is the client for the path finder \n ");
            var grid1 = GridBuilder.GetGrid();
            var grid2 = GridBuilder.GetGrid();

        
            var response1 = testBFS.BFS(grid1, new int[2] { 0, 0 }, new int[2] { 39, 39}, Factory.CreateEmptyResponse());
            var response2 = testDFS.DFS(grid2, new int[2] { 0, 0 }, new int[2] { 39, 39 }, Factory.CreateEmptyResponse());
            Console.WriteLine($"The BFS Distance Is {response1.Distance}");
            
            GridDrawer.Draw(GridBuilder.GetGrid(),response1);
            Console.WriteLine("\n\n\n");
            Console.WriteLine($"The DFS Distance Is {response2.Distance}");
            GridDrawer.Draw(GridBuilder.GetGrid(), response2);
        }
    }
}
 
