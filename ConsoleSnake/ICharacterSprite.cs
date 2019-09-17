using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSnake
{
    interface ICharacterSprite : ISprite
    {
        char Symbol { get; set; }
        ConsoleColor Color { get; set; }
    }
}
