using System.Text.RegularExpressions;

namespace AdventOfCode2024.Lib;
public partial class Day03Puzzle
{
    public partial class PartOneGeneratedRegexStrategy : ISolveStrategy
    {
        [GeneratedRegex(@"mul\((\d{1,3}),(\d{1,3})\)", RegexOptions.Singleline)]
        private static partial Regex CreateRegex();

        public int Solve(string dataFilePath)
        {
            var lines = File.ReadLines(dataFilePath);
            return SumOfValidMultiplications(lines);
        }

        private static int SumOfValidMultiplications(IEnumerable<string> lines)
        {
            var regex = CreateRegex();

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

    public partial class PartTwoGeneratedRegexStrategy : ISolveStrategy
    {
        [GeneratedRegex(@"mul\((\d{1,3}),(\d{1,3})\)|do\(\)|don't\(\)", RegexOptions.Singleline)]
        private static partial Regex CreateRegex();


        public int Solve(string dataFilePath)
        {
            var lines = File.ReadLines(dataFilePath);
            return SumOfValidMultiplications(lines);
        }

        private static int SumOfValidMultiplications(IEnumerable<string> lines)
        {
            var regex = CreateRegex();

            var sum = 0;
            var mulEnabled = true;

            foreach (var line in lines)
            {
                var matches = regex.Matches(line);

                foreach (Match match in matches)
                {
                    if (match.Groups[1].Success && match.Groups[2].Success)
                    {
                        if (mulEnabled)
                        {
                            var x = int.Parse(match.Groups[1].Value);
                            var y = int.Parse(match.Groups[2].Value);

                            sum += x * y;
                        }
                    }
                    else if (match.Value == "do()")
                    {
                        mulEnabled = true;
                    }
                    else if (match.Value == "don't()")
                    {
                        mulEnabled = false;
                    }
                   
                }
            }

            return sum;
        }
    }

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

    public partial class PartTwoRegexStrategy : ISolveStrategy
    {
        public int Solve(string dataFilePath)
        {
            var lines = File.ReadLines(dataFilePath);
            return SumOfValidMultiplications(lines);
        }

        private static int SumOfValidMultiplications(IEnumerable<string> lines)
        {
            var regex = new Regex(@"mul\((\d{1,3}),(\d{1,3})\)|do\(\)|don't\(\)", RegexOptions.Compiled | RegexOptions.Singleline);

            var sum = 0;
            var mulEnabled = true;

            foreach (var line in lines)
            {
                var matches = regex.Matches(line);

                foreach (Match match in matches)
                {
                    if (match.Groups[1].Success && match.Groups[2].Success)
                    {
                        if (mulEnabled)
                        {
                            var x = int.Parse(match.Groups[1].Value);
                            var y = int.Parse(match.Groups[2].Value);

                            sum += x * y;
                        }
                    }
                    else if (match.Value == "do()")
                    {
                        mulEnabled = true;
                    }
                    else if (match.Value == "don't()")
                    {
                        mulEnabled = false;
                    }

                }
            }

            return sum;
        }
    }
}
