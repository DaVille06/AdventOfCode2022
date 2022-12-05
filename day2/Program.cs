namespace day2;
class Program
{
    static void Main(string[] args)
    {
        var inputs = File.ReadAllLines("inputs.txt");
        var totalScore = 0;
        foreach (var round in inputs)
        {
            var opponent = round[0];
            var yourChoice = round[2];
            switch (opponent) 
            {
                case 'A':
                    switch (yourChoice)
                    {
                        case 'X':
                            totalScore += Draw('X');
                            break;
                        case 'Y':
                            totalScore += Win('Y');
                            break;
                        default:
                            totalScore += 3;
                            break;
                    }
                    break;
                case 'B':
                    switch (yourChoice)
                    {
                        case 'X':
                            totalScore += 1;
                            break;
                        case 'Y':
                            totalScore += Draw('Y');
                            break;
                        default:
                            totalScore += Win('Z');
                            break;
                    }
                    break;
                default:
                    switch (yourChoice)
                    {
                        case 'X':
                            totalScore += Win('X');
                            break;
                        case 'Y':
                            totalScore += 2;
                            break;
                        default:
                            totalScore += Draw('Z');
                            break;
                    }
                    break;
            }
        }

        Console.WriteLine(totalScore);

        // PART 2
        totalScore = 0;
        foreach (var round in inputs)
        {
            switch (round[0])
            {
                case 'A':
                    switch (round[2])
                    {
                        case 'X':
                            totalScore += 3;
                            break;
                        case 'Y':
                            totalScore += Draw('X');
                            break;
                        default:
                            totalScore += Win('Y');
                            break;
                    }
                    break;
                case 'B':
                    switch (round[2])
                    {
                        case 'X':
                            totalScore += 1;
                            break;
                        case 'Y':
                            totalScore += Draw('Y');
                            break;
                        default:
                            totalScore += Win('Z');
                            break;
                    }
                    break;
                default:
                    switch (round[2])
                    {
                        case 'X':
                            totalScore += 2;
                            break;
                        case 'Y':
                            totalScore += Draw('Z');
                            break;
                        default:
                            totalScore += Win('X');
                            break;
                    }
                    break;
            }
        }

        Console.WriteLine(totalScore);
    }

    static int Win(char choice)
    {
        switch (choice)
        {
            case 'X':
                return 6 + 1;
            case 'Y':
                return 6 + 2;
            default:
                return 6 + 3;
        }
    }

    static int Draw(char choice)
    {
        switch (choice)
        {
            case 'X':
                return 3 + 1;
            case 'Y':
                return 3 + 2;
            default:
                return 3 + 3;
        }
    }
}
