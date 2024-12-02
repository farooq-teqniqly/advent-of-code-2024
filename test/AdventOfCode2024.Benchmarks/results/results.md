# Advent of Code 2024 Benchmark Results

The benchmarks were done using [BenchmarkDotNet](https://benchmarkdotnet.org/)

## Day 1 Benchmark Results

| Method            |     Mean |   Error |  StdDev |    Gen0 |    Gen1 | Allocated |
| ----------------- | -------: | ------: | ------: | ------: | ------: | --------: |
| WithPriorityQueue | 342.3 us | 6.12 us | 9.89 us | 43.4570 |  3.9063 | 266.67 KB |
| WithLinqSort      | 227.4 us | 3.93 us | 4.03 us | 44.6777 | 10.4980 | 274.86 KB |
