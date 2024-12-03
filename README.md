# Advent of Code 2024

This document provides hints to the puzzles in [Advent of Code 2024](https://adventofcode.com/2024).

I solved the puzzles using C#.

The Visual Studio solution is structured as follows:

`src` folder contains the puzzle solution code.
`test` folder contains two test projects:

-   `AdventOfCode2024.Tests` is the project that runs the puzzle solution code and verifies the result. Run this project like you usually run test projects.
-   `AdventOfCode2024.Benchmarks` is the project that runs performance benchmarks on the puzzle solution code. These puzzles can be solved using multiple approaches and benchmarks provide an interesting way to compare approaches. The `results` folder contains a markdown document with a summary of the results.

`data` folder contains the input or puzzle files which serve as the input to the puzzle solution code.

## Running the Benchmarks

The command line shown below will run _all_ benchmarks.

```powershell
dotnet run -c Release -- --filter *
```

Each benchmark takes about a minute to run. If you want to run specfiic benchamrks, pass wildcard expressions to the `--filter` parameter:

```powershell
dotnet run -c Release -- --filter *Day01*
```

The above command will run only the Day01 benchmarks.

## Day 1

This is a sorting problem and so there are multiple ways you can tackle this puzzle. I thought of what is arguably the simplest solution - read the entire file into memory and sort the two lists of integers using LINQ.

I then thought about ways of sorting by reading one line at a time. This sounds better if the file was too large to fit into memory (not the case for this puzzle, but still interesting to think about). I used two priority queues to sort the numbers as they are read.

## Day 2

The choice here is wether to use LINQ or not. It is interesting to compare the performance characteristics of both approaches.

## Day 3

This is a straightforward regex problem. When working with regexes, Visual Studio might give you the following hint:

```
SYSLIB1045	Use 'GeneratedRegexAttribute' to generate the regular expression implementation at compile-time.
```

Hence there are two approaches to compare for benchmarking purposes, using `new Regex()` and using the [Regex Source Generators](https://learn.microsoft.com/en-us/dotnet/standard/base-types/regular-expression-source-generators) per the above hint. The execution time improvement with Regex Source Generators is staggering!
