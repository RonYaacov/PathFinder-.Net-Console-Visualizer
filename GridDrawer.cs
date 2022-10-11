using PathFinder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientPathFinder
{
    public static class GridDrawer
    {
        public static void Draw(string[][] grid, ISearchResponse response)
        {
            StepsMarker(grid, response);    
            PathMarker(grid, response);
            
            for(int row = 0; row<grid.Length; row++)
            {
                for(int node = 0; node<grid[row].Length; node++)
                {
                    switch (grid[row][node])
                    {
                        case ("S" or "F"):
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.Write(grid[row][node]);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(" ");
                            break;
                        case ("#"):
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(grid[row][node]);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(" ");
                            break;
                        case ("*"):
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(grid[row][node]);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(" ");
                            break;
                        case ("-"):
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.Write(0);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(" ");
                            break;
                        default:
                            Console.Write(grid[row][node] + " ");
                            break;
                    }
                }
                Console.WriteLine(" ");

            }
        }
        private static void StepsMarker(string[][]grid, ISearchResponse response)
        {
            for(var i=1;i<response.Steps.Count()-1;i++)
            {
                grid[response.Steps[i][0]][response.Steps[i][1]] = "-";
            }
        }
        private static void PathMarker(string[][] grid, ISearchResponse response)
        {
            var currentPosition = response.Steps[0];
            for(int i = 0; i < response.Distance-1; i++)
            {
                switch (response.Path[i])
                {
                    case ('U'):
                        currentPosition[0] = currentPosition[0] - 1;
                        grid[currentPosition[0]][currentPosition[1]] = "*";
                        break;
                    case ('R'):
                        currentPosition[1] = currentPosition[1] + 1;
                        grid[currentPosition[0]][currentPosition[1]] = "*";
                        break;
                    case ('D'):
                        currentPosition[0] = currentPosition[0] + 1;
                        grid[currentPosition[0]][currentPosition[1]] = "*";
                        break;
                    case ('L'):
                        currentPosition[1] = currentPosition[1] - 1;
                        grid[currentPosition[0]][currentPosition[1]] = "*";
                        break;
                   
                }
            }

        }
    }
}
