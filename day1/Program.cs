namespace day1;
class Program
{
    static void Main(string[] args)
    {
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
    }
}
