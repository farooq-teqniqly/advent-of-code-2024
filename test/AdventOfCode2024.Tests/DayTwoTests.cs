using AdventOfCode2024.Lib;
using FluentAssertions;

namespace AdventOfCode2024.Tests;
public class DayTwoTests
{
    private readonly string _dataFilePath = Utility.GetFullDataFilePath(2);
    
    [Fact]
    public void Can_Get_Safe_Report_Count_Part_One()
    {
        var count = Day02Puzzle.GetSafeReportsCountPartOne(_dataFilePath);
        count.Should().Be(639);
    }
}
