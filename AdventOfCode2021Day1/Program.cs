using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2021
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = File.ReadAllLines(
                Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + 
                "\\items.txt"
                ).Select(x => 
                    int.Parse(x))
                .ToArray();

            var result = Measure.GetAmountOfIncreases(data);
            Console.WriteLine(result);
        }
    }
}
