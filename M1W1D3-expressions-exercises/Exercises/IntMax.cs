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
        Given three int values, a b c, return the largest.
        intMax(1, 2, 3) → 3
        intMax(1, 3, 2) → 3
        intMax(3, 2, 1) → 3
        */
        public int IntMax(int a, int b, int c)
        {
            int superMax = 0;
            if ((a > b)  && (a > c))
            {
                superMax = a;
            }
            
            else if((b > a) && (b > c))
            {
                superMax = b;
            }

            else if((c > a) && (c > b))
            {
                superMax = c;
            }
            return superMax;
        }

    }
}
