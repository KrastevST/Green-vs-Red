using System;

namespace GreenVsRed
{
    public class GameFactory
    {
        public Game NewGame()
        {
            string[] firstLine = Console.ReadLine().Split(new[] { ',', ' '}, StringSplitOptions.RemoveEmptyEntries);
            int x = int.Parse(firstLine[0]);
            int y = int.Parse(firstLine[1]);

            int[,] grid = new int[x, y];
            for (int i = 0; i < y; i++)
            {
                string row = Console.ReadLine().Trim();
                for (int j = 0; j < x; j++)
                {
                    grid[j, i] = row[i] - '0';
                }
            }

            string[] lastLine = Console.ReadLine().Split(new[] { ',', ' '}, StringSplitOptions.RemoveEmptyEntries);
            int x1 = int.Parse(lastLine[0]);
            int y1 = int.Parse(lastLine[1]);
            int turns = int.Parse(lastLine[2]);


            return new Game(x, y, grid, x1, y1, turns);
        }
    }
}
