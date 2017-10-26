using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileSplitter;
using System.IO;

namespace FileSplitter
{
    class Program
    {
        static void Main(string[] args)
        {
            string dir = Environment.CurrentDirectory;
            Queue<string> lineHolder = new Queue<string>();

            Console.Write("What is the name of the input file? ");
            string file = Console.ReadLine();

            Console.Write("\nHow many lines of text (max) should there be in the split files? ");
            int maxLines = int.Parse(Console.ReadLine());

            using (StreamReader sr = new StreamReader(Path.Combine(dir, file)))
            {
                while (!sr.EndOfStream)
                {
                    lineHolder.Enqueue(sr.ReadLine());
                }
            }

            decimal numNewFiles = Math.Ceiling((decimal)lineHolder.Count() / maxLines);

            Console.WriteLine($"\nThe input file had {lineHolder.Count()} lines of text");
            Console.WriteLine($"\nFor a {lineHolder.Count()} line input file, this will produce {numNewFiles} output files");
            Console.WriteLine("\n\n***Generating Output***\n");

            for (int i = 1; i <= numNewFiles; i++)
            {
                string newFileName = $"{file.Substring(0, (file.IndexOf('.')))}-{i}";

                using (StreamWriter sw = new StreamWriter($"{newFileName}.txt"))
                {
                    for (int x = 0; x < maxLines; x++)
                    {
                        if (lineHolder.Count > 0)
                        {
                            sw.WriteLine(lineHolder.Dequeue());
                        }
                    }
                }
                Console.WriteLine($"Generating {newFileName}.txt");
            }

        }
    }
}
