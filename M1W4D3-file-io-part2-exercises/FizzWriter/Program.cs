using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using FizzWriter.Classes;

namespace FizzWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            string dir = Environment.CurrentDirectory;
            string file = "FizzBuzz.txt";
            string fullPath = Path.Combine(dir, file);


            using (StreamWriter sw = new StreamWriter(fullPath))
            {
                for (int i = 1; i <= 300; i++)
                {
                    sw.WriteLine($"{FizzBuzzer.Checker(i)}, {FizzBuzzer.Checker(++i)}, {FizzBuzzer.Checker(++i)}, {FizzBuzzer.Checker(++i)}, {FizzBuzzer.Checker(++i)} ");
                }
            }
        }
    }
}
