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

        public static int GetAmountOfThirdIncrementIncrease(int[] items)
        {
            if(items.Length == 0)
            {
                return 0;
            }

            var currentThree = items.Take(3).ToList();
            var previousSum = currentThree.Sum();

            var count = 0;

            for(int i = 3; i < items.Length; i++)
            {
                currentThree.RemoveAt(0);
                currentThree.Add(items[i]);

                var currentSum = currentThree.Sum();

                if (currentSum > previousSum)
                    count++;

                previousSum = currentSum;
            }
            return count;
        }
    }
}
