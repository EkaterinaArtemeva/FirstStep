Console.WriteLine();

string? inputLineA = Console.ReadLine();
string? inputLineB = Console.ReadLine();

if(inputLineA != null && inputLineB != null)
    {
        int inputNumberA = int.Parse(inputLineA);
        
        int inputNumberB = int.Parse(inputLineB);

        int NumberC = inputNumberA * inputNumberA;
         
        int NumberD = inputNumberB * inputNumberB;
        
        if(NumberC == inputNumberB || NumberD == inputNumberA)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }        