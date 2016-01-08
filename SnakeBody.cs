using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeTheGame
{
    /// <summary>
    /// Klasa której obiekty przechowują parametry dla każdej części węża
    /// </summary>
    class SnakeBody
    {
        public SnakeBody()
        {
            X = 0;
            Y = 0;
        }
        public int X { get; set; }
        public int Y { get; set; }
    }
}
