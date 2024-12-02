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
