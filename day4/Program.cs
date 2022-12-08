namespace day4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var inputs = File.ReadAllLines("inputs.txt");
            var fullyContainedSum = 0;

            foreach (var pair in inputs)
            {
                var assignments = pair.Split(',');

                var elf1Sections = assignments[0].Split('-');
                var elf1Start = int.Parse(elf1Sections[0]);
                var elf1End = int.Parse(elf1Sections[1]);

                var elf2Sections = assignments[1].Split('-');
                var elf2Start = int.Parse(elf2Sections[0]);
                var elf2End = int.Parse(elf2Sections[1]);

                if ((elf1Start <= elf2Start && elf1End >= elf2End) ||
                    (elf2Start <= elf1Start && elf2End >= elf1End))
                {
                    // full contains
                    fullyContainedSum++;
                }
            }

            Console.WriteLine(fullyContainedSum);
        }
    }
}