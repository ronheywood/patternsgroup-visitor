using System;
using System.Linq;

namespace MazeGame.MazeGames
{
    public class Program
    {
        public static void Main()
        {
            var game = new MazeGame();
            var maze = game.CreateMaze();
            Console.WriteLine(maze.Rooms.FirstOrDefault());
            Console.ReadKey();
        }
    }
}
