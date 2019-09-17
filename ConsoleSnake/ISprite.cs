using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSnake
{
    public interface ISprite
    {
        int CoordinateX { get; set; }
        int CoordinateY { get; set; }
    }
}
