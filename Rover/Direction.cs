using System;
using System.Collections.Generic;
using System.Text;

namespace Rover
{
    class Direction
    {
        private char _direction;

        public void SetDirection(char direction)
        {
            _direction = direction;
        }

        public char GetCurrentDirection()
        {
            return _direction;
        }
    }
}
