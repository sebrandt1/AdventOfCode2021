using Xunit;
using AdventOfCode2021;

namespace AdventOfCode2021Day1Tests
{
    public class Day3Tests
    {
        [Fact]
        public void Fail()
        {
            var bits = new[] {
                "00100",
                "11110",
                "10110",
                "10111",
                "10101",
                "01111",
                "00111",
                "11100",
                "10000",
                "11001",
                "00010",
                "01010"
            };

            var result = Day3.GetPowerConsumption(bits);

            Assert.Equal(198, result);
        }
    }
}
