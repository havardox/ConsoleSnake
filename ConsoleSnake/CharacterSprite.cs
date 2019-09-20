using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSnake
{
    public abstract class CharacterSprite : Sprite
    {
        public char Symbol { get; set; }
        public ConsoleColor Color { get; set; }

        public override void Place()
        {
        
            Console.ForegroundColor = Color;
            Console.SetCursorPosition(Coordinate.X, Coordinate.Y);
            Console.Write(Symbol);
            Console.ResetColor();
        }
    }
}
