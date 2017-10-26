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
         Given two lists of Integers, interleave them beginning with the first element in the first list followed
         by the first element of the second. Continue interleaving the elements until all elements have been interwoven.
         Return the new list. If the lists are of unequal lengths, simply attach the remaining elements of the longer
         list to the new list before returning it.
		 DIFFICULTY: HARD
         interleaveLists( [1, 2, 3], [4, 5, 6] )  ->  [1, 4, 2, 5, 3, 6]
         */
        public List<int> InterleaveLists(List<int> listOne, List<int> listTwo)
        {
            List<int> bigList = new List<int>();
            int sizeOne = listOne.Count;
            int sizeTwo = listTwo.Count;


            if (sizeOne >= sizeTwo)
            {
                for(int i = 0; i < sizeTwo; i++)
                {
                    bigList.Add(listOne[0]);
                    bigList.Add(listTwo[0]);
                    listOne.Remove(listOne[0]);
                }
                bigList.AddRange(listOne);
            }
            if(sizeTwo > sizeOne)
            {
                for (int i = 0; i < sizeOne; i++)
                {
                    bigList.Add(listOne[0]);
                    bigList.Add(listTwo[0]);
                    listTwo.Remove(listTwo[0]);
                }
                bigList.AddRange(listTwo);
            }

                return bigList;
        }
    }
}

