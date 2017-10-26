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
      Given 2 positive int values, return the larger value that is in the range 10..20 inclusive, 
      or return 0 if neither is in that range.
      max1020(11, 19) → 19
      max1020(19, 11) → 19
      max1020(11, 9) → 11
      */
        public int Max1020(int a, int b)
        {
            int closerTwenty = 0;
            if(((a >= 11 && a <= 20)) || ((b >= 11) && (b <= 20)))
            {
                if(a > b)
                {
                    closerTwenty = a;
                }
               
                else
                {
                    closerTwenty = b;
                }
            }
                return closerTwenty;
        }

    }
}
