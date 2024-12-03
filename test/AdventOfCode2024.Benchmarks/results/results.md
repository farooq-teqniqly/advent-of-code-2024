# Advent of Code 2024 Benchmark Results

The benchmarks were done using [BenchmarkDotNet](https://benchmarkdotnet.org/)

## Day 1 Benchmark Results

| Method            |     Mean |   Error |  StdDev |    Gen0 |    Gen1 | Allocated |
| ----------------- | -------: | ------: | ------: | ------: | ------: | --------: |
| WithPriorityQueue | 342.3 us | 6.12 us | 9.89 us | 43.4570 |  3.9063 | 266.67 KB |
| WithLinqSort      | 227.4 us | 3.93 us | 4.03 us | 44.6777 | 10.4980 | 274.86 KB |

## Conclusion

Priority queue was slower than using LINQ but that could be due to the overhead of reading the file one line at a time. The memory usage was slightly higher with the LINQ method as the entire file was read into memory prior to sorting.

### Time Complexity

-   Priority queue enqueue/dequeue is $O(n*log(n))$
-   LINQ's sorting is quite elaborate. It uses [Introspection Sort](https://www.geeksforgeeks.org/introsort-or-introspective-sort/) which can use HeapSort, QuickSort, MergeSort, and Insertion Sort. It doesn't necessarily pick one, it can use combinations based on the list's characteristics. In the end though, the complexity is $O(n*log(n))$.

### Space Complexity

-   Priority queue is $O(n)$ for the two queues.
-   Memory complexity for IntroSort isn't straightforward as it depends on the phase of the algorithm being used but pratically it is $O(log n)$

## Day 2 Benchmark Results

| Method             |     Mean |    Error |   StdDev |     Gen0 |   Gen1 |  Allocated |
| ------------------ | -------: | -------: | -------: | -------: | -----: | ---------: |
| PartOneWithLinq    | 525.4 us | 10.34 us | 15.79 us | 136.7188 | 3.9063 |  838.02 KB |
| PartTwoWithLinq    | 869.0 us | 17.29 us | 16.98 us | 323.2422 | 9.7656 | 1981.93 KB |
| PartOneWithoutLinq | 268.0 us |  5.30 us | 11.85 us |  71.2891 | 1.9531 |  438.38 KB |
| PartTwoWithoutLinq | 385.0 us |  6.96 us |  5.81 us | 118.1641 | 3.4180 |  724.17 KB |

## Conclusion

Using LINQ makes for more readable code at the expense of performance. The non-LINQ version is much more
time and space efficient.

### Time Complexity

-   For part one, the time complexity is $O(r*l)$ where $r$ is the number of reports and $l$ is the number of levels.
-   For part two, the removal of each level and re-check takes $O(r * l^2)$ time where $r$ is the number of reports and $l$ is the number of levels.

### Space Complexity

-   $O(l)$ where $l$ is the number of levels for the differences list and a copy of the modified levels.

## Day 3 Benchmark Results

| Method                    |       Mean |    Error |   StdDev |    Gen0 |    Gen1 |    Gen2 | Allocated |
| ------------------------- | ---------: | -------: | -------: | ------: | ------: | ------: | --------: |
| PartOneWithRegex          | 1,802.7 us | 34.97 us | 41.63 us | 74.2188 | 33.2031 | 15.6250 | 462.84 KB |
| PartOneWithGeneratedRegex |   281.3 us |  5.89 us | 17.27 us | 73.2422 | 15.1367 |  0.4883 | 449.41 KB |
| PartTwoWithRegex          | 2,268.9 us | 44.07 us | 63.20 us | 78.1250 | 11.7188 |  3.9063 | 479.91 KB |
| PartTwoWithGeneratedRegex |   247.9 us |  4.90 us | 11.35 us | 73.2422 | 15.1367 |  0.4883 | 449.41 KB |

### Conclusion

~6x to 9x execution time improvement by using [Regular Expression Source Generators](https://learn.microsoft.com/en-us/dotnet/standard/base-types/regular-expression-source-generators)! Listen to Microsoft and don't use `new Regex()` anymore!

### Time Complexity

-   The time complexity is $O(l+m)$ where $l$ is the length of the line and $m$ is the number of matches to process.

### Space Complexity

-   The space complexity is $O(m)$ where $m$ is the number of matches to process.
