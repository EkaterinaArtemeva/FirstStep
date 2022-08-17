string? inputLine = Console.ReadLine();

if(inputLine != null)
{
    int inputNumber = int.Parse(inputLine);

    if((inputNumber == 6) || (inputNumber == 7))
    {
        Console.WriteLine("выходной");
    }
    else
    {
        Console.WriteLine("рабочий");
    }
}
