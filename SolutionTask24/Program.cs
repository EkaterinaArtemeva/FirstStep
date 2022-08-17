Console.Clear();
Console.Write("введите число: ");

int inputNumber = int.Parse(Console.ReadLine());
int t;

void VariatSimple()
{
    int sumOfNumbers = 0;
    for (int i = 0; i <= inputNumber; i++)
    {
        sumOfNumbers += i;

        //sumOfNumbers=sumOfNumbers+1;
    }
    Console.WriteLine("сумма числе от 1 до " + inputNumber + " = " + sumOfNumbers);
}

t = Environment.TickCount;
VariatSimple();
Console.WriteLine("Simple time: {0} ms", Environment.TickCount - t);

void VariantGauss()
{
    int sumOfNumbers = 0;

    sumOfNumbers = ((1 + inputNumber) * inputNumber) / 2;

    Console.WriteLine("сумма числе от 1 до " + inputNumber + " = " + sumOfNumbers);
}

t = Environment.TickCount;
VariantGauss();
Console.WriteLine("Simple time: {0} ms", Environment.TickCount - t);