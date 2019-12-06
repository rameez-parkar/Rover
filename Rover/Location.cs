using System;
using System.Collections.Generic;
using System.Text;

namespace Rover
{
    class Location
    {
        Coordinates coordinates = new Coordinates();
        Direction direction = new Direction();


        public void ParseInitialLocation(string initialLocation) {
            coordinates.SetInitialXCoordinate(int.Parse(initialLocation.Split(',')[0].Split('(')[1]));
            coordinates.SetInitialYCoordinate(int.Parse(initialLocation.Split(',')[1]));
            direction.SetDirection(char.Parse(initialLocation.Split(',')[2].Split(')')[0]));
        }

        public void UpdateCoordinatePosition()
        {
            switch (direction.GetCurrentDirection())
            {
                case 'N':
                    coordinates.UpdateYCoordinate(direction);
                    break;
                case 'S':
                    coordinates.UpdateYCoordinate(direction);
                    break;
                case 'E':
                    coordinates.UpdateXCoordinate(direction);
                    break;
                case 'W':
                    coordinates.UpdateXCoordinate(direction);
                    break;
            }
        }

        public void UpdateDirection(char rotationSide)
        {
            switch (direction.GetCurrentDirection())
            {
                case 'N':
                    if (rotationSide == 'L')
                        direction.SetDirection('W');
                    else if (rotationSide == 'R')
                        direction.SetDirection('E');
                    break;
                case 'S':
                    if (rotationSide == 'L')
                        direction.SetDirection('E');
                    else if (rotationSide == 'R')
                        direction.SetDirection('W');
                    break;
                case 'E':
                    if (rotationSide == 'L')
                        direction.SetDirection('N');
                    else if (rotationSide == 'R')
                        direction.SetDirection('S');
                    break;
                case 'W':
                    if (rotationSide == 'L')
                        direction.SetDirection('S');
                    else if (rotationSide == 'R')
                        direction.SetDirection('N');
                    break;
            }
        }

        public string GetUpdatedLocation() {
            return "(" + coordinates.GetCurrentXCoordinate().ToString() + ", " + coordinates.GetCurrentYCoordinate().ToString() + ", " + direction.GetCurrentDirection().ToString() + ")";
        } 
    }
}
