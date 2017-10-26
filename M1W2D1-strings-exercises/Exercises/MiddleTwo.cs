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
         Given a string of even length, return a string made of the middle two chars, so the string "string" 
         yields "ri". The string length will be at least 2.
         middleTwo("string") → "ri"
         middleTwo("code") → "od"
         middleTwo("Practice") → "ct"
         */
        public string MiddleTwo(string str)
        {

           string newStr = "";
           int strtIndx = str.Length / 2;
          

            newStr = str.Substring(strtIndx - 1, 2);

            return newStr;
        }
    }
}