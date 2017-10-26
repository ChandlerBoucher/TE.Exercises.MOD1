using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exercises
{
    public class KataRomanNumerals
    {


        public string ConvertToRomanNumeral(int n)
        {
            string result = "";
            Dictionary<string, int> romanNums = new Dictionary<string, int>();

            romanNums["M"] = 1000;
            romanNums["CM"] = 900;
            romanNums["D"] = 500;
            romanNums["CD"] = 400;
            romanNums["C"] = 100;
            romanNums["XC"] = 90;
            romanNums["L"] = 50;
            romanNums["XL"] = 40;
            romanNums["X"] = 10;
            romanNums["IX"] = 9;
            romanNums["V"] = 5;
            romanNums["IV"] = 4;
            romanNums["I"] = 1;
            foreach (KeyValuePair<string, int> kvp in romanNums)
            {
                while (n >= kvp.Value)
                {
                    n -= kvp.Value;

                    result = result + kvp.Key;
                }
            }


            return result;
        }
        public int ConvertToArabic(string romanNum)
        {
            Dictionary<string, int> romanNums = new Dictionary<string, int>();

            int n = 0;
            romanNums["CM"] = 900;
            romanNums["CD"] = 400;
            romanNums["XC"] = 90;
            romanNums["XL"] = 40;
            romanNums["IX"] = 9;
            romanNums["IV"] = 4;
            romanNums["M"] = 1000;
            romanNums["D"] = 500;
            romanNums["C"] = 100;
            romanNums["L"] = 50;
            romanNums["X"] = 10;
            romanNums["V"] = 5;
            romanNums["I"] = 1;



            foreach (KeyValuePair<string, int> kvp in romanNums)
            {
                while (romanNum.Contains(kvp.Key))
                {
                    n += kvp.Value;

                    romanNum = romanNum.Remove(romanNum.IndexOf(kvp.Key), kvp.Key.Length);
                }
            }
            return n;
        }
    }
}
