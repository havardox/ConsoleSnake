using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSnake
{
    class Food : CharacterSprite
    {
        Board Board;
        public Food(char symbol, ConsoleColor color, Board board)
        {
            Symbol = symbol;
            Color = color;
            Board = board;
            Random rnd = new Random();
            Coordinate.X = rnd.Next(1, board.Width + 1);
            Coordinate.Y = rnd.Next(1, board.Height + 1);
        }

        public void Place()
    }
}
