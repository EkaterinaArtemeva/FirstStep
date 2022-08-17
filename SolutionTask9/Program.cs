System.Random numberSintezator = new Random();

int number = numberSintezator.Next(10, 100);

Console.WriteLine(number);
//вариант1
int firstNumber = number/10;
int secondNumber = number%10;

if (firstNumber>secondNumber)
{
    Console.WriteLine(firstNumber);
}

else
{
    Console.WriteLine(secondNumber);
}