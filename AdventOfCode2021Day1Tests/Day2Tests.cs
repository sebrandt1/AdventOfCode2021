using AdventOfCode2021;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AdventOfCode2021Day1Tests
{
    public class Day2Tests
    {
        [Fact]
        public void GetDepth_Part1()
        {
            var data = new[]
            {
                "forward 5",
                "down 5",
                "forward 8",
                "up 3",
                "down 8",
                "forward 2",
            };

            var result = Day2.GetDepth(data);

            Assert.Equal(150, result);
        }

        [Fact]
        public void GetDepth_Part2()
        {
            var data = new[]
            {
                "forward 5",
                "down 5",
                "forward 8",
                "up 3",
                "down 8",
                "forward 2"
            };

            var result = Day2.GetDepthWithAim(data);

            Assert.Equal(900, result);
        }
    }
}
