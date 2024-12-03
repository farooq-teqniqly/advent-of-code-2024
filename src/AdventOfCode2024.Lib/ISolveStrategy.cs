namespace AdventOfCode2024.Lib;

public partial class Day01Puzzle
{
    public interface ISolveStrategy
    {
        int Solve(string dataFilePath);
    }
}
