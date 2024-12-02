using System.Runtime.CompilerServices;

namespace AdventOfCode2024.Lib;
public class Utility
{
    public static string GetFullDataFilePath(int dayNumber)
    {
        if (dayNumber is < 0 or > 25)
        {
            throw new ArgumentOutOfRangeException( nameof(dayNumber), "value must be between 1 and 25 inclusive");
        }

        var fileName = $"Day{dayNumber}.txt";

        if (dayNumber < 10)
        {
            fileName = $"Day0{dayNumber}.txt";
        }

        return Path.Combine(Path.GetDirectoryName(WhereAmI())!, "../../", "data", fileName);

    }
    private static string WhereAmI([CallerFilePath] string callerFilePath = "") => callerFilePath;
}
