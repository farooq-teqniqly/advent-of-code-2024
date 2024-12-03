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

| Method       |     Mean |    Error |   StdDev |     Gen0 |   Gen1 |  Allocated |
| ------------ | -------: | -------: | -------: | -------: | -----: | ---------: |
| PartOne      | 564.9 us | 10.31 us | 14.78 us | 136.7188 | 3.9063 |  838.02 KB |
| PartTwo      | 977.1 us | 19.16 us | 26.86 us | 320.3125 | 7.8125 | 1981.93 KB |
| PartOneNoZip | 434.0 us | 10.45 us | 29.48 us |  94.2383 | 2.4414 |  578.73 KB |
| PartTwoNoZip | 668.9 us | 13.04 us | 21.05 us | 190.4297 | 4.8828 | 1166.59 KB |

## Conclusion

Using LINQ makes for more readable code at the expense of performance. When running the code under a profiler, the `Zip().ToList()` calls were particularly expensive. I was able to improve runtime and memory usage considerably by creating the differences array without using LINQ. Cotninuing this line of thinking, you would remove LINQ usage entirely if performance was critical.

### Time Complexity

-   For part one, the time complexity is $O(r*l)$ where $r$ is the number of reports and $l$ is the number of levels.

-   For part two, the removal of each level and re-check takes $O(r * l^2)$ time where $r$ is the number of reports and $l$ is the number of levels.

### Space Complexity

-   $O(l)$ where $l$ is the number of levels for the differences list and a copy of the modified levels.
