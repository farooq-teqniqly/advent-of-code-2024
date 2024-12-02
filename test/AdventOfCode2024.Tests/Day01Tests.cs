using AdventOfCode2024.Lib;
using FluentAssertions;

namespace AdventOfCode2024.Tests;

public class Day01Tests
{
    [Fact]
    public void Can_Get_The_Total_Distance()
    {
        var dataFilePath = Path.Join(Directory.GetCurrentDirectory(), "../../../../../", "data", "day01.txt");
        var distance = Day01Puzzle.Solve(dataFilePath);

        distance.Should().Be(1_579_939);
    }
}