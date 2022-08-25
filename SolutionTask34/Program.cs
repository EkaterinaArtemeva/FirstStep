//метод возвращает массив случайных чисел
int[] FillingArray()
{
    //создаем экземпляр класс рандомайзер
    int[] outArray = new int[123];
    //буферная переменная
    int i = 0;
    //выходной массив
    System.Random numberSintezator = new System.Random();
    //цикл заполнения массива
    while (i < 123)
    {
        //получаем новое значение
        outArray[i] = numberSintezator.Next(-1000, 1000);
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

//метод решает задачу
int CalculateTask(int[] inputArray, int downBorder, int upBorder)

{
    int resultCount = 0;
    int i = 0;
    while (i < inputArray.Length)
    {
        if (inputArray[i] >= downBorder && inputArray[i] <= upBorder)
        {
            Console.Write(inputArray[i] + " ");
            resultCount++;
        }
        i++;
    }
    return resultCount;
}


int[] bufferArray = FillingArray();
PrintIntArray(bufferArray);
Console.WriteLine(CalculateTask(bufferArray, 10, 99));