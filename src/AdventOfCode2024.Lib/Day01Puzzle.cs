namespace AdventOfCode2024.Lib;

public partial class Day01Puzzle
{
    public class PriorityQueueSolveStrategy : ISolveStrategy
    {
        public int Solve(string dataFilePath)
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

    public class LinqSortSolveStrategy : ISolveStrategy
    {
        public int Solve(string dataFilePath)
        {
            var lines = File.ReadAllLines(dataFilePath);
            var leftList = new List<int>();
            var rightList = new List<int>();

            foreach (var line in lines)
            {
                var parts = line.Split("   ").Select(int.Parse).ToArray();
                leftList.Add(parts[0]);
                rightList.Add(parts[1]);
            }

            leftList.Sort();
            rightList.Sort();

            return leftList.Select((left, index) => Math.Abs(left - rightList[index])).Sum();
        }
    }

    public static int Solve(ISolveStrategy solveStrategy, string dataFilePath) => solveStrategy.Solve(dataFilePath);
}
