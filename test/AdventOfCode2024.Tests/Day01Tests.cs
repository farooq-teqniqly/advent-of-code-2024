using AdventOfCode2024.Lib;
using FluentAssertions;

namespace AdventOfCode2024.Tests;

public class Day01Tests
{
    private readonly string _dataFilePath = Utility.GetFullDataFilePath(1);

    [Fact]
    public void Can_Get_The_Total_Distance_Using_Priority_Queue()
    {
        var strategy = new Day01Puzzle.PriorityQueueSolveStrategy();
        var distance = Day01Puzzle.Solve(strategy, _dataFilePath);

        distance.Should().Be(1_579_939);
    }

    [Fact]
    public void Can_Get_The_Total_Distance_Using_Linq_Sort()
    {
        var strategy = new Day01Puzzle.LinqSortSolveStrategy();
        var distance = Day01Puzzle.Solve(strategy, _dataFilePath);

        distance.Should().Be(1_579_939);
    }
}
