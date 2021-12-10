using AdventOfCode2021;
using System;
using Xunit;

namespace AdventOfCode2021Day1Tests
{
    public class Day1Tests
    {
        [Fact]
        public void GetAmountOfIncreases_Part1()
        {
            var data = new int[]
            {
                105,
                106,
                101,
                100,
                105,
                150,
                145,
                200
            };

            var result = Day1.GetAmountOfIncreases(data);

            Assert.Equal(4, result);
        }

        [Fact]
        public void GetThreeMeasurementIncrease_Part2()
        {
            var data = new int[]
            {
                199,
                200,
                208,
                210,
                200,
                207,
                240,
                269,
                260,
                263
            };

            var result = Day1.GetAmountOfThirdIncrementIncrease(data);

            Assert.Equal(5, result);
        }
    }
}
