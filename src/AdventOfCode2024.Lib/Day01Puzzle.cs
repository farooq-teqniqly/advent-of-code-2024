namespace AdventOfCode2024.Lib;

public class Day01Puzzle
{
    public static int Solve(string dataFilePath)
    {
        var lines = File.ReadLines(dataFilePath);
        var leftQueue = new PriorityQueue<int, int>();
        var rightQueue = new PriorityQueue<int, int>();

        foreach (var line in lines)
        {
            var parts = line.Split("   ").Select(int.Parse).ToArray();
            var leftValue = parts[0];
            var rightValue = parts[1];

            leftQueue.Enqueue(leftValue, leftValue);
            rightQueue.Enqueue(rightValue, rightValue);
        }

        var totalDistance = 0;

        while (leftQueue.Count > 0 && rightQueue.Count > 0)
        {
            totalDistance += Math.Abs(leftQueue.Dequeue() - rightQueue.Dequeue());
        }

        return totalDistance;
    }
}
