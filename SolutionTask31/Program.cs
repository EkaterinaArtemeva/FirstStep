//переменные для накопления результата
int positiveSum = 0;
int negatibeSum = 0;

//метод возвращает массив случайных чисел
int[] FillingArray()
{
    //создаем экземпляр класс рандомайзер
    int[] outArray = new int[12];
    //буферная переменная
    int i = 0;
    //выходной массив
    System.Random numberSintezator = new System.Random();
    //цикл заполнения массива
    while (i < 12)
    {
        //получаем новое значение
        outArray[i] = numberSintezator.Next(-9, 10);
        //увеличиваем инкремент
        i++;
    }
    //возвращам значение
    return outArray;
}
//метод подсчета положительных и отрицательных значений
void CalculateTask(int[] outArray)
{
    int i = 0;
    while (i < 12)
    {
        if (outArray[i] > 0)
        {
            positiveSum++;
        }
        else
        {
            negatibeSum++;
        }
        i++;
    }
}
//выводим результат на консоль
void PrintResult()
{
    Console.WriteLine(positiveSum);
    Console.WriteLine(negatibeSum);
}


void VariantNaive()
{
    int[] bufferArray = FillingArray();
    CalculateTask(bufferArray);
    PrintResult();
}

VariantNaive();