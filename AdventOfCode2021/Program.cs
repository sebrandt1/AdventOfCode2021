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
            //Part1
            var data1 = File.ReadAllLines(
                Environment.GetFolderPath(Environment.SpecialFolder.Desktop) +
                "\\items.txt"
                ).Select(x =>
                    int.Parse(x))
                .ToArray();

            var result1 = Measure.GetAmountOfIncreases(data1);
            Console.WriteLine(result1);

            //Part2
            var data2 = File.ReadAllLines(
                Environment.GetFolderPath(Environment.SpecialFolder.Desktop) +
                "\\items.txt"
                ).Select(x =>
                    int.Parse(x))
                .ToArray();

            var result2 = Measure.GetAmountOfThirdIncrementIncrease(data2);
            Console.WriteLine(result2);

            Console.ReadKey();
        }
    }
}
