using System.Collections.Generic;

namespace MazeGame.MazeGames
{
    public class MazeGame
    {
        public MapSite CreateMaze()
        {
            var maze = new MapSite();
            var room1 = new Room();
            var room2 = new Room();
            var theDoor = new Door(room1, room2);

            room1.SetSide(Direction.NORTH, new Wall());
            room1.SetSide(Direction.EAST, theDoor);
            room1.SetSide(Direction.SOUTH, new Wall());
            room1.SetSide(Direction.WEST, new Wall());

            room2.SetSide(Direction.NORTH, new Wall());
            room2.SetSide(Direction.EAST, new Wall());
            room2.SetSide(Direction.SOUTH, new Wall());
            room2.SetSide(Direction.WEST, theDoor);

            maze.AddRooms( new List<Room>(){ room1,room2 } );
            return maze;
        }
    }
}