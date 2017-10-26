﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {


        /*
         Your cell phone rings. Return true if you should answer it. Normally you answer, except in the morning 
         you only answer if it is your mom calling. In all cases, if you are asleep, you do not answer.
         answerCell(false, false, false) → true
         answerCell(false, false, true) → false
         answerCell(true, false, false) → false
         */
        public bool AnswerCell(bool isMorning, bool isMom, bool isAsleep)
        {
            bool answerRing = false;
            if (isAsleep)
            {
                answerRing = false;
            }
           else if(isMorning)
            {
                if (isMom)
                {
                    answerRing = true;
                }
                else
                {
                    answerRing = false;
                }
            }
            else
            {
                answerRing = true;
            }

            return answerRing;
        }
    }
}