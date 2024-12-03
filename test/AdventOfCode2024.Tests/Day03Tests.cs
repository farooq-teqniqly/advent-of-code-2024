using AdventOfCode2024.Lib;
using FluentAssertions;

namespace AdventOfCode2024.Tests;
public class Day03Tests
{
    private readonly string _dataFilePath = Utility.GetFullDataFilePath(3);

    [Fact]
    public void Can_Get_Sum_With_Regex_Part_One()
    {
        var sum = new Day03Puzzle.PartOneRegexStrategy().Solve(_dataFilePath);
        sum.Should().Be(166_630_675);
    }

    [Fact]
    public void Can_Get_Sum_With_Regex_Part_Two()
    {
        var sum = new Day03Puzzle.PartTwoRegexStrategy().Solve(_dataFilePath);
        sum.Should().Be(93_465_710);
    }
}
