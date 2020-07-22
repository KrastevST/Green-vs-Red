using System;

namespace GreenVsRed
{
    class Program
    {
        static void Main()
        {
            string[] firstLine = Console.ReadLine().Trim().Split();
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

            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    Console.WriteLine(grid[j,i]);
                }
            }
        }
    }
}
