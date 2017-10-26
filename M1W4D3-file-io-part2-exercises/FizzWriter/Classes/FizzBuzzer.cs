using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzWriter.Classes
{
    public static class FizzBuzzer
    {
        public static string Checker(double num)
        {
            string result = num.ToString();

            if (num % 5 == 0 && num % 3 == 0)
            {
                result = "FizzBuzz";
            }

            else if (num % 5 == 0 || num.ToString().Contains("5"))
            {
                result = "Buzz";
            }

            else if (num % 3 == 0 || num.ToString().Contains("3"))
            {
                result = "Fizz";
            }


            return result;
        }
    }
}
