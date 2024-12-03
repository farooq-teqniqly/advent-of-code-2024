using AdventOfCode2024.Lib;
using BenchmarkDotNet.Attributes;

namespace AdventOfCode2024.Benchmarks;

[MemoryDiagnoser]
public class Day03Benchmarks
{
    private readonly string _dataFilePath = Utility.GetFullDataFilePath(3);

    [Benchmark]
    public int PartOneWithRegex() => new Day03Puzzle.PartOneRegexStrategy().Solve(_dataFilePath);

    [Benchmark]
    public int PartOneWithGeneratedRegex() => new Day03Puzzle.PartOneGeneratedRegexStrategy().Solve(_dataFilePath);

    [Benchmark]
    public int PartTwoWithRegex() => new Day03Puzzle.PartTwoRegexStrategy().Solve(_dataFilePath);

    [Benchmark]
    public int PartTwoWithGeneratedRegex() => new Day03Puzzle.PartOneGeneratedRegexStrategy().Solve(_dataFilePath);
}
