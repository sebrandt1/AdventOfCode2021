using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AdventOfCode2021
{
    public class Day2
    {
        public static int GetDepth(string[] directions)
        {
            var values = new Dictionary<string, int>()
            {
                ["forward"] = 0,
                ["depth"] = 0
            };

            var regex = new Regex("(forward|up|down) [0-9]+");
            if(directions.All(x => regex.IsMatch(x)))
            {
                for(int i = 0; i < directions.Length; i++)
                {
                    var items = directions[i].ToLower().Split(' ');
                    var key = items[0];
                    if(items.Length == 2 && int.TryParse(items[1], out var move))
                    {
                        if(key.Equals("up"))
                        {
                            values["depth"] -= move;
                        }
                        else if(key.Equals("down"))
                        {
                            values["depth"] += move;
                        }
                        else if(key.Equals("forward"))
                        {
                            values["forward"] += move;
                        }
                    }
                }
            }
            else throw new InvalidOperationException("Invalid directional values.");

            return values["depth"] * values["forward"];
        }

        public static int GetDepthWithAim(string[] directions)
        {
            var aim = 0;
            var forward = 0;
            var depth = 0;

            for(int i = 0; i < directions.Length; i++)
            {
                var items = directions[i].Split(' ');
                var dir = items[0];
                var steps = int.Parse(items[1]);


                switch(dir)
                {
                    case "forward":
                        if (aim > 0) depth = depth + steps * aim;
                        forward += steps;
                        break;
                    case "up":
                        aim -= steps;
                        break;
                    case "down":
                        aim += steps;
                        break;
                }
            }
            return depth * forward;
        }
    }
}
