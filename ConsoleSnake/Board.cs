using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSnake
{
    public class Board : ISprite
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Coordinate Coordinate { get; set; }
        public Board(int width, int height, Coordinate coordinate)
        {
            Width = width - 3;
            Height = height - 2;
            Coordinate = coordinate;
        }

        public void Generate()
        {
            for (int i = Coordinate.Y; i < Height + 2; i++)
            {
                int increment = i == Coordinate.Y || i == Height + 1
                ? 2
                : Width - Coordinate.X + 1;
                for(int j = Coordinate.X; j < Width + 3; j += increment)
                    {
                    Console.SetCursorPosition(j, i);
                    Console.Write("{}");
                }
            }
        }
    }
}
