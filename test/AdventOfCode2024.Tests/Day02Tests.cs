using AdventOfCode2024.Lib;
using FluentAssertions;

namespace AdventOfCode2024.Tests;
public class Day02Tests
{
    private readonly string _dataFilePath = Utility.GetFullDataFilePath(2);
    
    [Fact]
    public void Can_Get_Safe_Report_Count_Part_One()
    {
        var count = Day02Puzzle.GetSafeReportsCountPartOne(_dataFilePath);
        count.Should().Be(639);
    }

    [Fact]
    public void Can_Get_Safe_Report_Count_Part_One_No_Zip()
    {
        var count = Day02Puzzle.GetSafeReportsCountPartOne(_dataFilePath, false);
        count.Should().Be(639);
    }

    [Fact]
    public void Can_Get_Safe_Report_Count_Part_Two()
    {
        var count = Day02Puzzle.GetSafeReportsCountPartTwo(_dataFilePath);
        count.Should().Be(674);
    }

    [Fact]
    public void Can_Get_Safe_Report_Count_Part_Two_No_Zip()
    {
        var count = Day02Puzzle.GetSafeReportsCountPartTwo(_dataFilePath, false);
        count.Should().Be(674);
    }

}
