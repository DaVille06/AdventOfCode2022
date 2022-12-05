namespace day3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var inputs = File.ReadAllLines("inputs.txt");
            var prioritySum = 0;

            // Part 1
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
            }
            Console.WriteLine(prioritySum);

            // Part 2
            prioritySum = 0;
            var dictionary = new Dictionary<char, int>();
            for (int i = 0; i < inputs.Length; i++)
            {
                if (i % 3 == 0) 
                    dictionary.Clear();

                var lineSet = new HashSet<char>();
                foreach (var compartment in inputs[i])
                {
                    if (!lineSet.Contains(compartment))
                    {
                        lineSet.Add(compartment);
                        if (dictionary.ContainsKey(compartment))
                        {
                            dictionary[compartment]++;

                            // 'Win Condition'
                            // If we have hit 3 then the value was on all 3 lines
                            if (dictionary[compartment] == 3) 
                            {
                                prioritySum += CalculatePriority(compartment);
                                break;
                            }
                        }
                        else
                        {
                            dictionary.Add(compartment, 1);
                        }
                    }
                }
            }
            Console.WriteLine(prioritySum);
        }

        static int CalculatePriority(int priority)
        {
            return priority >= 97 ? priority - 96 : priority - 38;
        }
    }
}