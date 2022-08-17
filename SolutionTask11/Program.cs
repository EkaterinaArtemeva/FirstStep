string? inputLineA = Console.ReadLine();
string? inputLineB = Console.ReadLine();

if(inputLineA != null && inputLineB != null)
    {
        int inputNumberA = int.Parse(inputLineA);
        
        int inputNumberB = int.Parse(inputLineB);

        int div = inputNumberB%inputNumberA;
        
        if(div == 0)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine(div);
        }
    }        