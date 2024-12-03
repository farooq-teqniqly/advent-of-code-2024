using System.Text.RegularExpressions;

namespace AdventOfCode2024.Lib;
public class Day03Puzzle
{
    public class PartOneRegexStrategy : ISolveStrategy
    {
        public int Solve(string dataFilePath)
        {
            var lines = File.ReadLines(dataFilePath);
            return SumOfValidMultiplications(lines);
        }

        private static int SumOfValidMultiplications(IEnumerable<string> lines)
        {
            var regex = new Regex(@"mul\((\d{1,3}),(\d{1,3})\)", RegexOptions.Compiled | RegexOptions.Singleline);

            var sum = 0;

            foreach (var line in lines)
            {
                var matches = regex.Matches(line);

                foreach (Match match in matches)
                {
                    var x = int.Parse(match.Groups[1].Value);
                    var y = int.Parse(match.Groups[2].Value);

                    sum += x * y;
                }
            }

            return sum;
        }
    }
}
