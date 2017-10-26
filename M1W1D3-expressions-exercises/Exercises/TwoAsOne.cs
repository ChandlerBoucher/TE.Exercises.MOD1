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
         Given three ints, a b c, return true if it is possible to add two of the ints to get the third.
         twoAsOne(1, 2, 3) → true
         twoAsOne(3, 1, 2) → true
         twoAsOne(3, 2, 2) → false
         */
        public bool TwoAsOne(int a, int b, int c)
        {

            bool twoFer = true;

            if (a + b == c)
            {
                twoFer = true;
            }
            else if (a + c == b)
            {
                twoFer = true;
            }
            else if (b + c == a)
            {
                twoFer = true;
            }
            else
                twoFer = false;

            return twoFer;
        }

    }
}
