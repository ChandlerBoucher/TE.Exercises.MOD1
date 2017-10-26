using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class StringExercises
    {
        /*
         Given a string, return true if the first instance of "x" in the string is immediately followed by another "x".
         doubleX("axxbb") → true
         doubleX("axaxax") → false
         doubleX("xxxxx") → true
         */
        public bool DoubleX(string str)
        {
            bool xAndX = false;
            int x1 = str.IndexOf('x');
            if (x1 < str.Length - 1)
            {
                char x2 = str[x1 + 1];

                if (x2 == 'x')
                {
                    xAndX = true;
                }
            }
            else
            {
                xAndX = false;
            }

            return xAndX;
        }
    }
}
