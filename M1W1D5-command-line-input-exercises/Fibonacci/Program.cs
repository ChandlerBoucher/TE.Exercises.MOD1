using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        /*
         The Fibonacci numbers are the integers in the following sequence:  
	        0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, ...
         By definition, the first two numbers in the Fibonacci sequence are 0 and 1, and each subsequent number is the sum of the previous two.
 
         Write a command line program which prompts the user for an integer value and display the Fibonacci sequence leading up to that number.
  
         C:\Users> Fiboncci
         Please enter the Fibonacci number: 25
         
         0, 1, 1, 2, 3, 5, 8, 13, 21
         */
        static void Main(string[] args)
        {
            for (int runs = 1; runs < 99; runs++)
            {

                Console.WriteLine("Please enter the Fibonacci number : ");

                string depth = Console.ReadLine();

                int sequenceNum = int.Parse(depth);
                int[] fibiValues = new int[sequenceNum + 1];
                int n = sequenceNum;
                int b = 1;
                int a = 0;
                int i = 0;
                switch(sequenceNum)
                {
                    case 0:
                        Console.Write("0, ");
                            break;
                    case 1:
                        Console.Write("0, 1, ");
                        break;
                }

                for ( i = 0; i < sequenceNum; i += n)
                {


                    if (n == 1 || n == 2)
                    {
                        fibiValues[i] = 1;
                        Console.Write($"{fibiValues[n]}, ");
                    }

                    n = b + a;
                    a = b;
                    b = n;
                    fibiValues[i] = n;


                }
                    while (n <=sequenceNum)
                    {
                        Console.Write($"{fibiValues[i]}");
                    }
                
            }
        }
    }
}

    

