namespace MazeGame.MazeElements.EnchantedMaze
{
    public class EnchantedRoom : Room
    {
        public override string ToString()
        {
            var room = string.Join("\r\n", _sides);
            return $"You are in a Magical Realm. You see\r\n{room}.\r\n{_exits}\r\n\r\nThorin sits down and starts singing about gold.";
        }
    }
}