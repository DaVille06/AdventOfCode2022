using System.Linq;

namespace day1;
class Program
{
    static void Main(string[] args)
    {

        // PUZZLE 1
        var calorieInputs = File.ReadAllLines("input.txt");
        var currentSum = 0;
        var maxSum = 0;

        foreach (var snack in calorieInputs)
        {
            if (string.IsNullOrEmpty(snack))
            {
                maxSum = Math.Max(currentSum, maxSum);
                currentSum = 0;
            }
            else
            {
                currentSum += int.Parse(snack);
            }
        }

        Console.WriteLine(Math.Max(currentSum, maxSum));

        // PUZZLE 2
        // resetting current since we used it above
        currentSum = 0;
        var top3 = new List<int>();
        foreach (var snack in calorieInputs)
        {
            if (string.IsNullOrEmpty(snack))
            {
                top3.Add(currentSum);

                if (top3.Count > 3)
                {
                    // we need to remove lowest
                    top3.Remove(top3.Min());
                }

                // reset current sum
                currentSum = 0;
            }
            else
            {
                currentSum += int.Parse(snack);
            }
        }

        Console.WriteLine(top3.Sum());
    }
}
