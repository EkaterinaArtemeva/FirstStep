// int coordXPointA;
// int coordYPointA;
// int coordXPointB;
// int coordYPointB;
// double lengthAB;

// // Считывает координаты точек
// void readDataOfPoint()
// {
//     Console.WriteLine("Введите координату X точки A");
//     coordXPointA = int.Parse(Console.ReadLine());

//     Console.WriteLine("Введите координату Y точки A");
//     coordYPointA = int.Parse(Console.ReadLine());

//     Console.WriteLine("Введите координату X точки B");
//     coordXPointB = int.Parse(Console.ReadLine());

//     Console.WriteLine("Введите координату Y точки B");
//     coordYPointB = int.Parse(Console.ReadLine());
// }

// // Вычислаяет расстояние между точками
// void calculateLengthAB()
// {
//     double lengthAB = Math.Sqrt(Math.Pow((coordXPointA-coordXPointB),2)+Math.Pow((coordYPointA-coordYPointB),2));
// }

// readDataOfPoint();
// calculateLengthAB();

// Console.WriteLine(lengthAB);

Console.WriteLine("Введите координату X точки A");
int coordXPointA = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату Y точки A");
int coordYPointA = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату X точки B");
int coordXPointB = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату Y точки B");
int coordYPointB = int.Parse(Console.ReadLine());

double lengthAB = Math.Sqrt(Math.Pow((coordXPointA-coordXPointB),2)+Math.Pow((coordYPointA-coordYPointB),2));

Console.WriteLine(lengthAB);