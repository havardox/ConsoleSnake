using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSnake
{
    class Board : Sprite
    {
        int Width;
        int Height;
        public Board(int coordinateX, int coordinateY, int width, int height) : base(coordinateX, coordinateY)
        {
            CoordinateX = coordinateX;
            CoordinateY = coordinateY;
            Width = width;
            Height = height;
        }

        public void GenerateBoard()
        {
            for (int i = CoordinateX; i < Height; i++)
            {
                int increment = i == 0 || i == Height - 1
                ? 2
                : Width - 2;
                for(int j = CoordinateY; j < Width; j += increment)
                {
                    Console.SetCursorPosition(j, i);
                    Console.Write("{}");
                }
            }
        }
    }
}
