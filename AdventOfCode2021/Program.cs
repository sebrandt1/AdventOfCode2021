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
                ).ToArray();

            var result1 = Day3.GetPowerConsumption(data1);
            Console.WriteLine(result1);

            Console.ReadKey();
        }
    }
}
