using System;
using System.Collections.Generic;
using System.Text;

namespace Rover
{

    class Rover
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

        private string GetUpdatedLocation()
        {
            return location.GetUpdatedLocation();
        }
    }
}
