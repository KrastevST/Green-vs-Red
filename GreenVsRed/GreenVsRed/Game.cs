﻿using Contracts;

namespace GreenVsRed
{
    public class Game : IGame
    {
        const int green = 1;
        const int red = 0;

        private int x;
        private int y;
        private int[,] grid;
        private int x1;
        private int y1;
        private int turns;

        public Game(int x, int y, int[,] genZero, int x1, int y1, int turns)
        {
            this.x = x;
            this.y = y;
            this.grid = genZero;
            this.x1 = x1;
            this.y1 = y1;
            this.turns = turns;
        }

        public int Start()
        {
            int count = 0;
            if (grid[x1, y1] == green)
            {
                count++;
            }

            for (int i = 0; i < this.turns; i++)
            {
                nextTurn();
                if (grid[x1, y1] == green)
                {
                    count++;
                }
            }

            return count;
        }

        private void nextTurn()
        {
            int[,] nextGrid = new int[x, y];

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    nextGrid[i, j] = nextCell(i, j);
                }
            }

            this.grid = nextGrid;
        }

        private int nextCell(int x, int y)
        {
            int newCell = 0;
            int greenNeighbours = countNeigbours(x, y, green);

            if (grid[x, y] == red)
            {
                if (greenNeighbours == 3 || greenNeighbours == 6)
                {
                    newCell = green;
                }
                else
                {
                    newCell = red;
                }
            }
            else if (grid[x, y] == green)
            {
                if (greenNeighbours == 2 || greenNeighbours == 3 || greenNeighbours == 6)
                {
                    newCell = green;
                }
                else
                {
                    newCell = red;
                }
            }
           
            return newCell;
        }

        private int countNeigbours(int x, int y, int color)
        {
            int count = 0;
            if (x - 1 >= 0 && grid[x - 1, y] == color)
            {
                count++;
            }

            if (y - 1 >= 0 && grid[x, y - 1] == color)
            {
                count++;
            }

            if (x + 1 < this.x && grid[x + 1, y] == color)
            {
                count++;
            }

            if (y + 1 < this.y && grid[x, y + 1] == color)
            {
                count++;
            }

            if (x - 1 >= 0 && y - 1 >= 0 && grid[x - 1, y - 1] == color)
            {
                count++;
            }

            if (x - 1 >= 0 && y + 1 < this.y && grid[x - 1, y + 1] == color)
            {
                count++;
            }

            if (x + 1 < this.x && y - 1 >= 0 && grid[x + 1, y - 1] == color)
            {
                count++;
            }

            if (x + 1 < this.x && y + 1 < this.y && grid[x + 1, y + 1] == color)
            {
                count++;
            }

            return count;
        }
    }
}
