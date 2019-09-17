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
            Board board = new Board(0, 0, Console.WindowWidth, Console.WindowHeight - 10);
            board.Generate();
            Food food = new Food('O', ConsoleColor.Green);
            food.Place(board);
            while (true)
            {
                
            }
        }
    }
}
