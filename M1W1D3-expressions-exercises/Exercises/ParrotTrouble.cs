using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         We have a loud talking parrot. The "hour" parameter is the current hour time in the range 0..23. 
         We are in trouble if the parrot is talking and the hour is before 7 or after 20. Return true if 
         we are in trouble.
         parrotTrouble(true, 6) → true
         parrotTrouble(true, 7) → false
         parrotTrouble(false, 6) → false
         */
        public bool ParrotTrouble(bool talking, int hour)
        {

            int mornTrouble = (7 - hour);
            int eveTrouble = (20 - hour);
            bool inTrouble = false;

            if(talking)
            {
               if(mornTrouble > 0)
                {
                    inTrouble = true;
                }
               else if(eveTrouble < 0)
                {
                    inTrouble = true;
                }
            }
            else
            {
                inTrouble = false;
            }
            return inTrouble;
        }

    }
}
