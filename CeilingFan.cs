using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ceiling_Fan
{
    class CeilingFan
    {
        private int speed = 0;  //0 is off, max of 3
        private bool direction = true;  //true is clockwise, false is counterclockwise

        public CeilingFan()
        {
        }

        public int GetSpeed()   //initial setup, no hardcoding
        {
            return speed;
        }

        public string GetDirection()    //initial setup, no hardcoding
        {
            if (direction)
            {
                return "Clockwise";
            }
            else if (!direction)    //may be unnecessary
            {
                return "Counterclockwise";
            }

            return "";    //if error
        }

        public int IncreaseSpeed()
        {
            speed++;

            if (speed > 3)  //set to off(0) if beyond max speed(3)
            {
                speed = 0;
            }

            return speed;
        }

        public string ChangeDirection()
        {
            if (direction)  //change clockwise to counterclockwise
            {
                direction = false;
                return "Counterclockwise";
            }
            else if (direction == false)    //change counterclockwise to clockwise
            {
                direction = true;
                return "Clockwise";
            }
            
            return null;    //if error
        }

    }
}
