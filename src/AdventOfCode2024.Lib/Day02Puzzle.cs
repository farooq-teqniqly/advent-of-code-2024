using System.Collections.Immutable;

namespace AdventOfCode2024.Lib;
public class Day02Puzzle
{
    public static int GetSafeReportsCountPartOne(string dataFilePath)
    {
        var lines = File.ReadLines(dataFilePath);
        return GetSafeReportsCountPartOne(lines);
    }

    private static int GetSafeReportsCountPartOne(IEnumerable<string> lines)
    {
        var safeReportCount = 0;

        foreach (var line in lines)
        {
            var numbers = line.Split(" ").Select(int.Parse).ToArray();
            var differences = new int[numbers.Length - 1];

            for (var i = 0; i < differences.Length; i++)
            {
                var difference = numbers[i + 1] - numbers[i];
                var absDifference = Math.Abs(difference);

                if (absDifference is < 1 or > 3)
                {
                    continue;
                }
                
                differences[i] = difference;
            }

            if (differences.All(i => i > 0) || differences.All(i => i < 0))
            {
                safeReportCount++;
            }
        }

        return safeReportCount;
    }
}
