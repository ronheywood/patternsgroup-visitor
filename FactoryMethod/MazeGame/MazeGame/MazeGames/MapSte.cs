using System.Collections.Generic;

namespace MazeGame.MazeGames
{
    public class MapSite
    {
        public List<Room> Rooms = new List<Room>();
        public  void AddRooms(List<Room> roomsToAdd)
        {
            Rooms.AddRange(roomsToAdd);
        }
    }
}