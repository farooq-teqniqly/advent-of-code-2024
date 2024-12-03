using AdventOfCode2024.Lib;
using FluentAssertions;

namespace AdventOfCode2024.Tests;
public class Day02Tests
{
    private readonly string _dataFilePath = Utility.GetFullDataFilePath(2);
    
    [Fact]
    public void Can_Get_Safe_Report_Count_With_Linq_Part_One()
    {
        var strategy = new Day02Puzzle.PartOneLinqSolveStrategy();
        var count = strategy.Solve(_dataFilePath);
        count.Should().Be(639);
    }

    [Fact]
    public void Can_Get_Safe_Report_Count_With_Linq_Part_Two()
    {
        var strategy = new Day02Puzzle.PartTwoLinqSolveStrategy();
        var count = strategy.Solve(_dataFilePath);
        count.Should().Be(674);
    }
}
