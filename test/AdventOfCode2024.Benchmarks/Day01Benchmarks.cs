using AdventOfCode2024.Lib;
using BenchmarkDotNet.Attributes;

namespace AdventOfCode2024.Benchmarks;

[MemoryDiagnoser]
public class Day01Benchmarks
{
    private readonly string _dataFilePath = Utility.GetFullDataFilePath(1);

    [Benchmark]
    public int WithPriorityQueue() => new Day01Puzzle.PriorityQueueSolveStrategy().Solve(_dataFilePath);

    [Benchmark]
    public int WithLinqSort() => new Day01Puzzle.LinqSortSolveStrategy().Solve(_dataFilePath);
}
