using AdventOfCode2024.Lib;
using FluentAssertions;

namespace AdventOfCode2024.Tests;

public class Day01Tests
{
    [Fact]
    public void Can_Get_The_Total_Distance_Using_Priority_Queeu()
    {
        var dataFilePath = Path.Join(Directory.GetCurrentDirectory(), "../../../../../", "data", "day01.txt");
        var strategy = new Day01Puzzle.PriorityQueueSolveStrategy();
        var distance = Day01Puzzle.Solve(strategy, dataFilePath);

        distance.Should().Be(1_579_939);
    }
}
