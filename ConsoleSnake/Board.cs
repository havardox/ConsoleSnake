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
        public int CoordinateX { get; set; }
        public int CoordinateY { get; set; }
        public Board(int coordinateX, int coordinateY, int width, int height)
        {
            CoordinateX = coordinateX;
            CoordinateY = coordinateY;
            Width = width - 3;
            Height = height - 2;
        }

        public void Generate()
        {
            for (int i = CoordinateY; i < Height + 2; i++)
            {
                int increment = i == CoordinateY || i == Height + 1
                ? 2
                : Width - CoordinateX + 1;
                for(int j = CoordinateX; j < Width + 3; j += increment)
                    {
                    Console.SetCursorPosition(j, i);
                    Console.Write("{}");
                }
            }
        }
    }
}
