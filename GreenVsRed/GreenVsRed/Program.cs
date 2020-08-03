using Contracts;
using System;

namespace GreenVsRed
{
    class Program
    {
        static void Main()
        {
            IGameFactory gameFactory = new GameFactory();
            IGame game = gameFactory.NewGame();
            int result = game.Start();
            Console.WriteLine(result);
            
        }
    }
}
