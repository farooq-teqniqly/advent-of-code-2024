using AdventOfCode2024.Lib;
using BenchmarkDotNet.Attributes;

namespace AdventOfCode2024.Benchmarks;

[MemoryDiagnoser]
public class Day02Benchmarks
{
    private readonly string _dataFilePath = Utility.GetFullDataFilePath(2);

    [Benchmark]
    public int PartOne() => Day02Puzzle.GetSafeReportsCountPartOne(_dataFilePath);


    [Benchmark]
    public int PartTwo() => Day02Puzzle.GetSafeReportsCountPartTwo(_dataFilePath);
}
