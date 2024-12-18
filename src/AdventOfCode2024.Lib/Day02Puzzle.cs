namespace AdventOfCode2024.Lib;
public class Day02Puzzle
{
    public class PartOneLinqSolveStrategy : ISolveStrategy
    {
        public int Solve(string dataFilePath)
        {
            var lines = File.ReadLines(dataFilePath);
            return GetSafeReportsCountPartOne(lines);
        }

        private static int GetSafeReportsCountPartOne(IEnumerable<string> lines)
        {
            var safeReportCount = 0;

            foreach (var line in lines)
            {
                var levels = line.Split(" ").Select(int.Parse).ToArray();

                if (IsSafe(levels))
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
    }

    public class PartTwoLinqSolveStrategy : ISolveStrategy
    {
        public int Solve(string dataFilePath)
        {
            var lines = File.ReadLines(dataFilePath);
            return GetSafeReportsCountPartTwo(lines);
        }

        private static int GetSafeReportsCountPartTwo(IEnumerable<string> lines)
        {
            var safeReportCount = 0;

            foreach (var line in lines)
            {
                var levels = line.Split(" ").Select(int.Parse).ToArray();

                if (IsSafe(levels))
                {
                    safeReportCount++;
                    continue;
                }

                var canBeMadeSafe = false;

                for (var i = 0; i < levels.Length; i++)
                {
                    var modifiedLevels = new List<int>(levels);
                    modifiedLevels.RemoveAt(i);

                    if (!IsSafe([.. modifiedLevels]))
                    {
                        continue;
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
    }

    public class PartOneNoLinqSolveStrategy : ISolveStrategy
    {
        public int Solve(string dataFilePath)
        {
            var lines = File.ReadLines(dataFilePath);
            return GetSafeReportsCountPartOne(lines);
        }

        private static int GetSafeReportsCountPartOne(IEnumerable<string> lines)
        {
            var safeReportCount = 0;

            foreach (var line in lines)
            {
                var levels = line.Split(" ").Select(int.Parse).ToArray();

                if (IsSafe(levels))
                {
                    safeReportCount++;
                }
            }

            return safeReportCount;
        }

        private static bool IsSafe(int[] levels)
        {
            var isIncreasing = true;
            var isDecreasing = true;

            for (var i = 0; i < levels.Length - 1; i++)
            {
                var difference = levels[i + 1] - levels[i];
                var absDifference = difference < 0 ? -difference : difference;

                if (absDifference is < 1 or > 3)
                {
                    return false;
                }

                switch (difference)
                {
                    case < 0:
                        isIncreasing = false;
                        break;
                    case > 0:
                        isDecreasing = false;
                        break;
                }
            }

            return isIncreasing || isDecreasing;
        }
    }

    public class PartTwoNoLinqSolveStrategy : ISolveStrategy
    {
        public int Solve(string dataFilePath)
        {
            var lines = File.ReadLines(dataFilePath);
            return GetSafeReportsCountPartOne(lines);
        }

        private static int GetSafeReportsCountPartOne(IEnumerable<string> lines)
        {
            var safeReportCount = 0;

            foreach (var line in lines)
            {
                var levels = line.Split(" ").Select(int.Parse).ToArray();

                if (IsSafe(levels))
                {
                    safeReportCount++;
                    continue;
                }

                var canBeMadeSafe = false;

                for (var i = 0; i < levels.Length; i++)
                {
                    var modifiedLevels = new List<int>(levels);
                    modifiedLevels.RemoveAt(i);

                    if (!IsSafe([.. modifiedLevels]))
                    {
                        continue;
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
            var isIncreasing = true;
            var isDecreasing = true;

            for (var i = 0; i < levels.Length - 1; i++)
            {
                var difference = levels[i + 1] - levels[i];
                var absDifference = difference < 0 ? -difference : difference;

                if (absDifference is < 1 or > 3)
                {
                    return false;
                }

                switch (difference)
                {
                    case < 0:
                        isIncreasing = false;
                        break;
                    case > 0:
                        isDecreasing = false;
                        break;
                }
            }

            return isIncreasing || isDecreasing;
        }
    }
}
