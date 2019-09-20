using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSnake
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board(Console.WindowWidth, Console.WindowHeight - 10, new Coordinate { X = 0, Y = 0 });
            board.Generate();
            Food food = new Food('O', ConsoleColor.Green);
            food.Place(board);
            while (true)
            {
                
            }
        }
    }
}
