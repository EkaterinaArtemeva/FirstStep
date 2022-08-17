
string? inputLineA = Console.ReadLine();
string? inputLineB = Console.ReadLine();
int NumberC;

void One()
{
    if (inputLineA != null && inputLineB != null)
    {
        int inputNumberA = int.Parse(inputLineA);
        int inputNumberB = int.Parse(inputLineB);
        int NumberC = (int)Math.Pow(inputNumberA, inputNumberB);
    }
}

void Two()
{
    int i = 0;
    int NumberC = 1;
    int inputNumberA = int.Parse(inputLineA);
    int inputNumberB = int.Parse(inputLineB);
    while (i < inputNumberB)
        {
            NumberC = NumberC * inputNumberA;
        }    
}

Console.WriteLine(NumberC);