using System;
using System.Collections.Generic;

namespace MazeGame
{
    public class Room
    {
        protected string _exits;
        protected List<string> _sides = new List<string>();

        public override string ToString()
        {
            var room = string.Join("\r\n",_sides);
            return $"You are in a Room you see \r\n{room}.\r\nIt is otherwise un-remarkable.\r\n{_exits}";
        }

        public void SetSide(Direction direction, Wall wall)
        {
            _sides.Add(wall.ToString());
        }

        public void SetSide(Direction direction, Door theDoor)
        {
            _exits = "Exits are "  + (Direction)direction;
        }
    }
}