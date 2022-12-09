namespace day6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = File.ReadAllLines("inputs.txt")[0];
            var dict = new Dictionary<char, int> { { input[0], 0 } };
            var leftHand = 0;
            var result = 0;

            for (int rightHand = 1; rightHand < input.Length; rightHand++)
            {
                if (dict.ContainsKey(input[rightHand]))
                {
                    // if it is then left hand moves to that position + 1
                    // by walking the array and removing values from dictionary
                    // it also updates the dictionary of the right hand with the new index
                    // and removes any values that were to the left of it

                    // get current right hand index
                    var foundIndex = dict[input[rightHand]];
                    // walk leftHand until it is equal to foundIndex + 1
                    for (int i = leftHand; i <= foundIndex; i++)
                    {
                        dict.Remove(dict.FirstOrDefault(x => x.Value == i).Key);
                    }
                    leftHand = foundIndex + 1;
                    dict.Add(input[rightHand], rightHand);
                }
                else
                {
                    // if not it records the value in dictionary and continues
                    dict.Add(input[rightHand], rightHand);
                }

                // PART 1
                // if (dict.Count() == 4)
                // PART 2
                if (dict.Count() == 14)
                {
                    // + 1 for 0 index
                    result = rightHand + 1;
                    break;
                }
            }
            Console.WriteLine(result);
        }
    }
}