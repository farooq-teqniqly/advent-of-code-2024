using AdventOfCode2024.Lib;
using BenchmarkDotNet.Attributes;

namespace AdventOfCode2024.Benchmarks;

[MemoryDiagnoser]
public class Day02Benchmarks
{
    private readonly string _dataFilePath = Utility.GetFullDataFilePath(2);

    [Benchmark]
    public int PartOneWithLinq() => new Day02Puzzle.PartOneLinqSolveStrategy().Solve(_dataFilePath);


    [Benchmark]
    public int PartTwoWithLinq() => new Day02Puzzle.PartTwoLinqSolveStrategy().Solve(_dataFilePath);

    [Benchmark]
    public int PartOneWithoutLinq() => new Day02Puzzle.PartOneNoLinqSolveStrategy().Solve(_dataFilePath);

    [Benchmark]
    public int PartTwoWithoutLinq() => new Day02Puzzle.PartTwoNoLinqSolveStrategy().Solve(_dataFilePath);
}
