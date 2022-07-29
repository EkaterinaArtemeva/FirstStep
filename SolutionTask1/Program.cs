string? inputLineOne = Console.ReadLine();
string? inputLineTwo = Console.ReadLine();

if(inputLineOne != null && inputLineTwo != null){
    int inputNumOne = int.Parse(inputLineOne);
    int inputNumTwo = int.Parse(inputLineTwo);

    if(inputNumOne == inputNumTwo * inputNumTwo)
    {
        Console.WriteLine("yes");
    }
    else
    {
        Console.WriteLine("no");
    }
}