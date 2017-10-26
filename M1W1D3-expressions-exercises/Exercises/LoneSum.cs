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
         Given 3 int values, a b c, return their sum. However, if one of the values is the same as another 
         of the values, it does not count towards the sum.
         loneSum(1, 2, 3) → 6
         loneSum(3, 2, 3) → 2
         loneSum(3, 3, 3) → 0
         */
        public int LoneSum(int a, int b, int c)
        {
            int sumSum = a + b + c;
            if((a == b) && (b == c))
            {
                sumSum = 0;
            }
            else if(b == a)
            {
                sumSum = c;
            }
            else if (b == c)
            {
                sumSum = a;
            }
            else if (a == c)
            {
                sumSum = b;
            }
            return sumSum;
        }

    }
}
