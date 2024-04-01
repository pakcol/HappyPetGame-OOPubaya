using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SnakeGame
{
    public class Circle
    {
        #region Data Members
        private int x;
        private int y;
        #endregion

        #region Constructors
        public Circle()
        {
            this.X = 0;
            this.Y = 0;
        }
        public Circle(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        #endregion

        #region Properties
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        #endregion
    }
}