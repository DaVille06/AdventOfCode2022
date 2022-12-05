namespace day3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var inputs = File.ReadAllLines("inputs.txt");
            var prioritySum = 0;

            foreach (var rucksack in inputs)
            {
                var set1 = new HashSet<char>();
                var set2 = new HashSet<char>();
                var compartmentSize = rucksack.Length / 2;
                // split in half
                var compartment1 = rucksack.Substring(0, compartmentSize);
                var compartment2 = rucksack.Substring(compartmentSize);
                // find common letter in each half
                for (int i = 0; i < compartmentSize; i++)
                {
                    if (compartment1[i] == compartment2[i])
                    {
                        prioritySum += CalculatePriority(compartment1[i]);
                        break;
                    }
                    else if (set2.Contains(compartment1[i]))
                    {
                        // add compartment 1
                        prioritySum += CalculatePriority(compartment1[i]);
                        break;
                    }
                    else if (set1.Contains(compartment2[i]))
                    {
                        prioritySum += CalculatePriority(compartment2[i]);
                        break;
                    }
                    else
                    {
                        set1.Add(compartment1[i]);
                        set2.Add(compartment2[i]);
                    }
                }

                Console.WriteLine(prioritySum);
            }
        }

        static int CalculatePriority(int priority)
        {
            return priority >= 97 ? priority - 96 : priority - 38;
        }
    }
}