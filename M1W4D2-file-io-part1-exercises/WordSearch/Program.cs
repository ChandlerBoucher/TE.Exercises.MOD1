using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WordSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Ask the user for the search string
            //2. Ask the user for the file path
            //3. Open the file
            //4. Loop through each line in the file
            //5. If the line contains the search string, print it out along with its line number
            Console.Write("Please enter a phrase to search for: ");
            string desiredString = Console.ReadLine();
            Console.WriteLine("Please enter the full file path including the file it is in: ");
            string filePath = Console.ReadLine();
            Console.WriteLine("Should this search be case sensitive (Y)es or (N)o ");
            string caseSense = Console.ReadLine();
            caseSense = caseSense.ToUpper();

            int lineCount = 1;
            using (StreamReader sr = new StreamReader(filePath))
            {
                if (caseSense == "Y")
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        if (line.Contains(desiredString))
                        {
                            Console.WriteLine($"{lineCount}) {line}");
                        }
                        lineCount++;
                    }
                }
                else
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        if (line.Contains(desiredString) || line.Contains(desiredString.ToUpper()) || line.Contains(desiredString.ToLower()))
                        {
                            Console.WriteLine($"{lineCount}) {line}");
                        }
                        lineCount++;
                    }
                }
            }
            Console.ReadLine();

        }
    }
}
