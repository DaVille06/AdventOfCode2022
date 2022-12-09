using System.Collections;
using System.Text;

namespace day5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // need an array of stacks
            var inputs = File.ReadAllLines("inputs.txt");
            var stacks = FillList();

            //for (int i = 10; i < inputs.Length; i++)
            //{
            //    var input = inputs[i].Split(' ');

            //    // 1 3 5
            //    // input 1 how many times
            //    for (int j = 0; j < int.Parse(input[1]); j++)
            //    {
            //        // input 3 is stack to pop
            //        var pop = stacks[int.Parse(input[3]) - 1].Pop();
            //        // input 5 is stack to push
            //        stacks[int.Parse(input[5]) - 1].Push(pop);
            //    }
            //}

            //StringBuilder sb = new StringBuilder();
            //foreach (var stack in stacks)
            //{
            //    sb.Append(stack.Peek());
            //}

            //Console.WriteLine(sb.ToString());

            for (int i = 10; i < inputs.Length; i++)
            {
                var input = inputs[i].Split(' ');

                // 1 3 5
                // input 1 how many times
                var newStack = new  Stack<char>();
                for (int j = 0; j < int.Parse(input[1]); j++)
                {
                    // input 3 is stack to pop
                    var pop = stacks[int.Parse(input[3]) - 1].Pop();

                    newStack.Push(pop);
                }

                // input 5 is stack to push
                foreach (var item in newStack)
                {
                    stacks[int.Parse(input[5]) - 1].Push(item);
                }
            }

            StringBuilder sb = new StringBuilder();
            foreach (var stack in stacks)
            {
                sb.Append(stack.Peek());
            }

            Console.WriteLine(sb.ToString());
        }

        static List<Stack<char>> FillList()
        {
            List<Stack<char>> stacks = new List<Stack<char>>();
            
            stacks.Add(new Stack<char>());
            stacks[0].Push('Z');
            stacks[0].Push('P');
            stacks[0].Push('M');
            stacks[0].Push('H');
            stacks[0].Push('R');

            stacks.Add(new Stack<char>());
            stacks[1].Push('P');
            stacks[1].Push('C');
            stacks[1].Push('J');
            stacks[1].Push('B');

            stacks.Add(new Stack<char>());
            stacks[2].Push('S');
            stacks[2].Push('N');
            stacks[2].Push('H');
            stacks[2].Push('G');
            stacks[2].Push('L');
            stacks[2].Push('C');
            stacks[2].Push('D');

            stacks.Add(new Stack<char>());
            stacks[3].Push('F');
            stacks[3].Push('T');
            stacks[3].Push('M');
            stacks[3].Push('D');
            stacks[3].Push('Q');
            stacks[3].Push('S');
            stacks[3].Push('R');
            stacks[3].Push('L');

            stacks.Add(new Stack<char>());
            stacks[4].Push('F');
            stacks[4].Push('S');
            stacks[4].Push('P');
            stacks[4].Push('Q');
            stacks[4].Push('B');
            stacks[4].Push('T');
            stacks[4].Push('Z');
            stacks[4].Push('M');

            stacks.Add(new Stack<char>());
            stacks[5].Push('T');
            stacks[5].Push('F');
            stacks[5].Push('S');
            stacks[5].Push('Z');
            stacks[5].Push('B');
            stacks[5].Push('G');

            stacks.Add(new Stack<char>());
            stacks[6].Push('N');
            stacks[6].Push('R');
            stacks[6].Push('V');

            stacks.Add(new Stack<char>());
            stacks[7].Push('P');
            stacks[7].Push('G');
            stacks[7].Push('L');
            stacks[7].Push('T');
            stacks[7].Push('D');
            stacks[7].Push('V');
            stacks[7].Push('C');
            stacks[7].Push('M');

            stacks.Add(new Stack<char>());
            stacks[8].Push('W');
            stacks[8].Push('Q');
            stacks[8].Push('N');
            stacks[8].Push('J');
            stacks[8].Push('F');
            stacks[8].Push('M');
            stacks[8].Push('L');

            return stacks;
        }
    }
}