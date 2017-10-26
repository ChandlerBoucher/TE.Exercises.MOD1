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
         Given a string, return a version without both the first and last char of the string. The string 
         may be any length, including 0.
         withouEnd2("Hello") → "ell"
         withouEnd2("abc") → "b"
         withouEnd2("ab") → ""
         */
        public string WithouEnd2(string str)
        {

            string newStr = "";
            if(str.Length <= 2)
            {
                newStr = "";
            }

            else
            {
                newStr = str.Substring(1, str.Length - 2);
            }

            return newStr;
        }
    }
}
