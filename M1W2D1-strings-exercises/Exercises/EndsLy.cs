﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class StringExercises
    {
        /*
         Given a string, return true if it ends in "ly".
         endsLy("oddly") → true
         endsLy("y") → false
         endsLy("oddy") → false
         */
        public bool EndsLy(string str)
        {

            bool lyEnd = false;

            if(str.Length > 1 && str[str.Length - 1] == 'y')
            {
                if(str[str.Length - 2] == 'l')
                {
                    lyEnd = true;
                }
            }
            else
            {
                lyEnd = false;
            }
            return lyEnd;
        }
    }
}
