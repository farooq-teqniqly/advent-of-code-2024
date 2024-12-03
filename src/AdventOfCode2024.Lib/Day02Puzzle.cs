using System.Collections.Immutable;

namespace AdventOfCode2024.Lib;
public class Day02Puzzle
{
    public static int GetSafeReportsCountPartOne(string dataFilePath, bool useZip = true)
    {
        var lines = File.ReadLines(dataFilePath);
        return GetSafeReportsCountPartOne(lines, useZip);
    }

    public static int GetSafeReportsCountPartTwo(string dataFilePath, bool useZip = true)
    {
        var lines = File.ReadLines(dataFilePath);
        return GetSafeReportsCountPartTwo(lines, useZip);
    }


    private static int GetSafeReportsCountPartOne(IEnumerable<string> lines, bool useZip = true)
    {
        var safeReportCount = 0;

        foreach (var line in lines)
        {
            var levels = line.Split(" ").Select(int.Parse).ToArray();

            if (useZip)
            {
                if (IsSafe(levels))
                {
                    safeReportCount++;
                }
            }
            else
            {
                if (IsSafeNoZip(levels))
                {
                    safeReportCount++;
                }
            }
        }

        return safeReportCount;
    }

    private static int GetSafeReportsCountPartTwo(IEnumerable<string> lines, bool useZip = true)
    {
        var safeReportCount = 0;

        foreach (var line in lines)
        {
            var levels = line.Split(" ").Select(int.Parse).ToArray();

            if (useZip)
            {
                if (IsSafe(levels))
                {
                    safeReportCount++;
                    continue;
                }
            }
            else
            {
                if (IsSafeNoZip(levels))
                {
                    safeReportCount++;
                    continue;
                }
            }

            var canBeMadeSafe = false;

            for (var i = 0; i < levels.Length; i++)
            {
                var modifiedLevels = new List<int>(levels);
                modifiedLevels.RemoveAt(i);

                if (useZip)
                {
                    if (!IsSafe([.. modifiedLevels]))
                    {
                        continue;
                    }
                }
                else
                {
                    if (!IsSafeNoZip([.. modifiedLevels]))
                    {
                        continue;
                    }
                }

                canBeMadeSafe = true;
                break;
            }

            if (canBeMadeSafe)
            {
                safeReportCount++;
            }
        }

        return safeReportCount;
    }

    private static bool IsSafe(int[] levels)
    {
        var differences = levels.Zip(levels.Skip(1), (l, r) => r - l).ToList();

        var allIncreasing = differences.All(i => i > 0);
        var allDecreasing = differences.All(i => i < 0);
            
        var withinRange = differences.All(d => Math.Abs(d) >= 1 && Math.Abs(d) <= 3);

        return (allIncreasing || allDecreasing) && withinRange;
    }

    private static bool IsSafeNoZip(int[] levels)
    {
        var differences = new int[levels.Length - 1];

        for (var i = 0; i < differences.Length; i++)
        {
            differences[i] = levels[i + 1] - levels[i];
        }

        var allIncreasing = differences.All(i => i > 0);
        var allDecreasing = differences.All(i => i < 0);

        var withinRange = differences.All(d => Math.Abs(d) >= 1 && Math.Abs(d) <= 3);

        return (allIncreasing || allDecreasing) && withinRange;
    }


}
