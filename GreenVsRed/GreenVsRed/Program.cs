using System;

namespace GreenVsRed
{
    class Program
    {
        static void Main()
        {
            var gameFactory = new GameFactory();
            var game = gameFactory.NewGame();
            int result = game.Start();
            Console.WriteLine(result);
            
        }
    }
}
