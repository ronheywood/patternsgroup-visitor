namespace MazeGame.MazeElements.BombedMaze
{
    public class BombedRoom : Room
    {
        public override string ToString()
        {
            var room = string.Join("\r\n", _sides);
            return $"You are in a dark abandoned warehouse. A sinister figure is running down the hall chattering something that sounds like \"Pop Quiz Rookie!\"\r\n\r\nYou see\r\n{room}.\r\n{_exits}";
        }
    }
}
