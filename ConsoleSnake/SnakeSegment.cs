using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSnake
{
    class SnakeSegment : ICharacterSprite
    {
        public int CoordinateX { get; set; }
        public int CoordinateY { get; set; }
        public char Symbol { get; set; }
        public ConsoleColor Color { get; set; }

        public SnakeSegment(char symbol, ConsoleColor color)
        {
            Symbol = symbol;
            Color = color;
        }

        public void Move(Direction direction)
        {
            switch (direction)
            {
                case Direction.Down:
                    CoordinateY -= 1;
                    break;
                case Direction.Up:
                    CoordinateY += 1;
                    break;
                case Direction.Left:
                    CoordinateX -= 1;
                    break;
                case Direction.Right:
                    CoordinateX += 1;
                    break;
            }
        }
    }
}
