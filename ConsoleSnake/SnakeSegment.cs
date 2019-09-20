using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSnake
{
    class SnakeSegment : CharacterSprite
    {
        public SnakeSegment(char symbol, ConsoleColor color, Coordinate coordinate)
        {
            Symbol = symbol;
            Color = color;
            Coordinate = coordinate;
        }

        public void Move(Direction direction)
        {
            switch (direction)
            {
                case Direction.Down:
                    Coordinate.Y -= 1;
                    break;
                case Direction.Up:
                    Coordinate.X += 1;
                    break;
                case Direction.Left:
                    Coordinate.X -= 1;
                    break;
                case Direction.Right:
                    Coordinate.X += 1;
                    break;
            }
        }
    }
}
