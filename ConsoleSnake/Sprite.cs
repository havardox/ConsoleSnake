﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSnake
{
    public abstract class Sprite
    {
        public virtual Coordinate Coordinate { get; set; }
    }
}