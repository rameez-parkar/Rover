using System;
using System.Collections.Generic;
using System.Text;

namespace Rover
{
    class Coordinates
    {
        private int _xCoordinate;
        private int _yCoordinate;

        public int GetCurrentXCoordinate()
        {
            return _xCoordinate;
        }

        public int GetCurrentYCoordinate()
        {
            return _yCoordinate;
        }

        public void SetInitialXCoordinate(int initialXCoordinate)
        {
            _xCoordinate = initialXCoordinate;
        }

        public void SetInitialYCoordinate(int initialYCoordinate)
        {
            _yCoordinate = initialYCoordinate;
        }

        public void UpdateXCoordinate(Direction direction)
        {
            if (direction.GetCurrentDirection() == 'E')
            {
                _xCoordinate++;
            }
            else if (direction.GetCurrentDirection() == 'W')
            {
                _xCoordinate--;
            }
        }

        public void UpdateYCoordinate(Direction direction)
        {
            if (direction.GetCurrentDirection() == 'N')
            {
                _yCoordinate++;
            }
            else if (direction.GetCurrentDirection() == 'S')
            {
                _yCoordinate--;
            }
        }
    }
}
