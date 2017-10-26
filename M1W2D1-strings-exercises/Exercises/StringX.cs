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
        Given a string, return a version where all the "x" have been removed. Except an "x" at the very start or end 
        should not be removed.
        stringX("xxHxix") → "xHix"
        stringX("abxxxcd") → "abcd"
        stringX("xabxxxcdx") → "xabcdx"
        */
        public string StringX(string str)
        {
            string newStr = "";

            if (str.Length <= 3)
            {
                newStr = str;
            }

            else
            {
                string inString = str.Substring(1, str.Length - 2);
                newStr = str[0] + inString.Replace("x", "") + str[str.Length - 1];
            }

            return newStr;
        }
    }
}
