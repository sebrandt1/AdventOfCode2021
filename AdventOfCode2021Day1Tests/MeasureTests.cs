using AdventOfCode2021;
using System;
using Xunit;

namespace AdventOfCode2021Day1Tests
{
    public class MeasureTests
    {
        [Fact]
        public void GetAmountOfIncreases_ShouldReturnAmountOfIncreases_WhenNonEmptyArrayIsInputted()
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

            var result = Measure.GetAmountOfIncreases(data);

            Assert.Equal(4, result);
        }

        [Fact]
        public void GetThreeMeasurementIncrease_ShouldReturnAmountOfIncreasesInEveryThirdIncrement_WhenArrayInputIsNotZero()
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

            var result = Measure.GetAmountOfThirdIncrementIncrease(data);

            Assert.Equal(5, result);
        }
    }
}
