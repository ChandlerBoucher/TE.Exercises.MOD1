using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class HomeworkAssignment
    {

        private int totalMarks;
        private int possibleMarks;
        private string submitterName;
       
        

        public HomeworkAssignment(int possibleMarks)
        {
            this.possibleMarks = possibleMarks;
        }
        
        public int PossibleMarks
        {
            get
            {
                return possibleMarks;
            }
        }

        public int TotalMarks
        {
            get
            {
                return totalMarks;
            }
            set
            {
                totalMarks = value;
            }
        }

        public string SubmitterName
        {
            get
            {
                return submitterName;
            }
            set
            {
                submitterName = value;
            }
        }

        public string LetterGrade
        {
            get
            { 
                if (totalMarks >= 90)
                {
                    return "A";
                }
                else if (totalMarks >= 80)
                {
                    return "B";
                }
                else if (totalMarks >= 70)
                {
                    return "C";
                }
                else if (totalMarks >= 60)
                {
                    return "D";
                }
                else
                {
                    return "F";
                }
                
            }
        }
    }
}
