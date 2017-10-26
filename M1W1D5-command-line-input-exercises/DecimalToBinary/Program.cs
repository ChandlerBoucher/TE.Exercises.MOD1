using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToBinary
{
    class Program
    {
        /*
        Write a command line program which prompts the user for a series of decimal integer values  
        and displays each decimal value as itself and its binary equivalent

        C:\Users> DecimalToBinary
        
        Please enter in a series of decimal values (separated by spaces): 460 8218 1 31313 987654321
        
        460 in binary is 111001100
        8218 in binary is 10000000011010
        1 in binary is 1
        31313 in binary is 111101001010001
        987654321 in binary is 111010110111100110100010110001
        */

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a series of decimal values seperated by spaces");

            string numEntry = Console.ReadLine();
        
            string[] arraytoConvert = numEntry.Split(' ');


            for (int i = 0; i <= arraytoConvert.Length - 1; i++)
            {

                int startNum = int.Parse(arraytoConvert[i]);
                decimal remainder = 0;
                decimal binaryResult = 0;
               
                decimal placeHolder = 1;
           
                while (startNum > 0)
                {
                    remainder = startNum % 2;
                    startNum = startNum / 2;
                    binaryResult = binaryResult + (remainder * placeHolder);
                    placeHolder = placeHolder * 10;

                }
                    Console.WriteLine($"{arraytoConvert[i]} in binary is {binaryResult}");
            }

            }
        }
    }

