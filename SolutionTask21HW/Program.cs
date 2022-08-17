//     int number;
//     int digit1;
//     int digit2;
//     int digit3;
//     int digit4;
//     int digit5;
    
// // Считывает точки
// void readOfPoint()
// {
//     int digit1 = number / 1000;
//     int digit2 = (number / 1000) % 10;
//     int digit3 = (number / 100) % 10;
//     int digit4 = (number / 10) % 10;
//     int digit5 = number % 10;
// }

// // Сравнивает пары точек
// void compareOfPoint()
// {
//     if (digit1 == digit5 && digit2 == digit4)
//     {
//         Console.WriteLine("палиндром");
//     }
//     else
//     {
//         Console.WriteLine("не палиндром");
//     }
// }

// readOfPoint();
// compareOfPoint();


string? inputLine = Console.ReadLine();

if (inputLine != null)
{
    int number = int.Parse(inputLine);

    int digit1 = number / 1000;
    int digit2 = (number / 1000) % 10;
    int digit3 = (number / 100) % 10;
    int digit4 = (number / 10) % 10;
    int digit5 = number % 10;

    if (digit1 == digit5 && digit2 == digit4)
    {
        Console.WriteLine("палиндром");
    }
    else
    {
        Console.WriteLine("не палиндром");
    }
}
