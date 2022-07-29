string? inputLine = Console.ReadLine();

if(inputLine != null)
{
    int inputNumberA = int.Parse(inputLine);

    int inputNumberB = inputNumberA%2;

    if(inputNumberB == 0)
    {
        Console.WriteLine("yes");
    }
    else
    {
        Console.WriteLine("no");
    }
}