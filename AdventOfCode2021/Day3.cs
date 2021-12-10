using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2021
{
   public class Day3
    {
        public static int GetPowerConsumption(string[] bits)
        {
            var ret = 0;
            var gamma = string.Empty;
            var epsilon = string.Empty;

            if (bits.All(x => x.Length == bits[0].Length
                 && x.All(y => y.Equals('1')
                     || y.Equals('0'))))
            {

                for (int x = 0; x < bits[0].Length; x++)
                {
                    var characterOccurence = new Dictionary<char, int>();

                    for (int y = 0; y < bits.Length; y++)
                    {
                        if(characterOccurence.ContainsKey(bits[y][x]))
                        {
                            characterOccurence[bits[y][x]]++;
                        }
                        else
                        {
                            characterOccurence.Add(bits[y][x], 1);
                        }
                    }
                    gamma += characterOccurence.Aggregate((cur, next) => 
                    cur.Value > next.Value 
                        ? cur : next).Key;

                    epsilon += characterOccurence.Aggregate((cur, next) => 
                    cur.Value < next.Value 
                        ? cur : next).Key;
                }

            }
            var gammaValue = int.Parse(Convert.ToString(Convert.ToInt32(gamma, 2), 10));
            var epsilonValue = int.Parse(Convert.ToString(Convert.ToInt32(epsilon, 2), 10));

            return gammaValue * epsilonValue;
        }
    }
}
