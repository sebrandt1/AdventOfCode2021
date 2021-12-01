using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2021
{
    public class Measure
    {
        public static int GetAmountOfIncreases(int[] items)
        {
            if(items.Length <= 1)
            {
                return 0;
            }

            var previous = items[0];

            return items.Count(x => 
            {
                var result = x > previous;
                previous = x;
                return result;
            });
        }
    }
}
