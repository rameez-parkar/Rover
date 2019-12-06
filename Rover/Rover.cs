using System;
using System.Collections.Generic;
using System.Text;

namespace Rover
{
//    The Rover

//You have a Rover that follows commands to move around on a plane surface.Locations on the surface are identified with an X-Y coordinate pair, and the Rover can face any one of 4 directions - North, South, East, West.

//Commands are a sequence of characters - or a string - of the form

//"LRLLMMMMLMMR" etc.So, given an initial location+direction combination (X, Y, D), and a command string C, you would want the Rover to process the command C and respond with an updated location+direction (X', Y', D').

//Eg:

//(0, 0, N) -- "MMM" -- (0, 3, N)

//(0, 1, E) -- "MML" -- (2, 1, N)

//(10, 5, N) -- "MMLMRMML" -- (?, ?, ?)

    public class Rovers
    {
        Location location = new Location();
        private string _commands;

        public void SetInitialValues(string initialLocation, string commands)
        {
            _commands = commands;
            location.ParseInitialLocation(initialLocation);
        }

        public void ReadCommand()
        {
            for(int command=0; command<_commands.Length; command++)
            {
                if(_commands[command] == 'M')
                {
                    _Move();
                }
                else if(_commands[command] == 'L')
                {
                    _ChangeDirection('L');
                }
                else if(_commands[command] == 'R')
                {
                    _ChangeDirection('R');
                }
            }
        }

        private void _Move() {
            location.UpdateCoordinatePosition();
        }

        private void _ChangeDirection(char direction) {
            location.UpdateDirection(direction);
        }

        public string GetUpdatedLocation()
        {
            return location.GetUpdatedLocation();
        }
    }
}
