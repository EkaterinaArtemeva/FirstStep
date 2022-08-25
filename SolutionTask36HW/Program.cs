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
        outArray[i] = numberSintezator.Next(100, 1000);
        //увеличиваем инкремент
        i++;
    }
    //возвращам значение
    return outArray;
}

//метод печатает массив
void PrintIntArray(int[] inputArray)
{
    int i = 0;
    while (i < inputArray.Length - 1)
    {
        Console.Write(inputArray[i] + ",");
        i++;
    }
    Console.WriteLine(inputArray[i]);
}

//метод считает количество четных чисел
int CalculateTask(int[] inputArray)

{
    int outputArray = 0;
    int i = 0;
    while (i < inputArray.Length)
    {
        if (inputArray[i] / 2 == 0)
        {
            outputArray++;
        }
        i++;
    }
    return outputArray;
}


int[] bufferArray = FillingArray();
PrintIntArray(bufferArray);
int resultArray = CalculateTask(bufferArray);
Console.WriteLine(bufferArray);

