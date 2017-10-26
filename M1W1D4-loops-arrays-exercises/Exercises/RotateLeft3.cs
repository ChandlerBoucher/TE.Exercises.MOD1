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
         Given an array of ints length 3, return an array with the elements "rotated left" so {1, 2, 3} 
         yields {2, 3, 1}.
         rotateLeft3([1, 2, 3]) → [2, 3, 1]
         rotateLeft3([5, 11, 9]) → [11, 9, 5]
         rotateLeft3([7, 0, 0]) → [0, 0, 7]
         */
        public int[] RotateLeft3(int[] nums)
        {
            int[] leftArray = new int[3];
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (i == 2)
                {
                    leftArray[1] = nums[i];
                }
                if (i == 1)
                {
                    leftArray[0] = nums[i];
                }
                if (i == 0)
                {
                    leftArray[2] = nums[i];
                }
            }
            return leftArray;
        }

    }
}
