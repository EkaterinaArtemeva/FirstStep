int number = new Random().Next(100,1000);
Console.WriteLine();
Console.WriteLine(number);

int numberOne = number/100;
int numberTwo = number%10;

Console.WriteLine();
Console.WriteLine(numberOne*10 + numberTwo);
