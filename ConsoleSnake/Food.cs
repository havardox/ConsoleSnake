using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSnake
{
    class Food : ICharacterSprite
    {
        public int CoordinateX { get; set; }
        public int CoordinateY { get; set; }
        public char Symbol { get; set; }
        public ConsoleColor Color { get; set; }

        public Food(char symbol, ConsoleColor color)
        {
            Symbol = symbol;
            Color = color;
        }

        public void Place(Board board)
        {
            Random rnd = new Random();
            Console.ForegroundColor = Color;
            CoordinateX = rnd.Next(1, board.Width + 1);
            CoordinateY = rnd.Next(1, board.Height + 1);
            Console.SetCursorPosition(CoordinateX, CoordinateY);
            Console.Write(Symbol);
        }
    }
}
