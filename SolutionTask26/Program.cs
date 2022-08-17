Console.Write("введите число: ");
string? inputLine = Console.ReadLine();
int inputNumber = int.Parse(inputLine);

Console.WriteLine(sumOfNumbers(inputNumber));

int sumOfNumbers(int number)
{
    int sumOfNumbers = 1;
    for (int i = 1; i <= inputNumber; i++)
    {
        sumOfNumbers *= i;
    }
    return sumOfNumbers;
}
