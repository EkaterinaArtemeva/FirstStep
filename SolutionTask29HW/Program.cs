Console.Write("введите число: ");
string? inputLine = Console.ReadLine();
int inputNumber = int.Parse(inputLine);

int inputNumberB = 0;

while (inputNumber > 0)
{
    inputNumberB = inputNumberB + inputNumber%10;
    inputNumber = inputNumber/10;
}

Console.WriteLine(inputNumberB);