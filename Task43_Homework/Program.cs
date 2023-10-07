// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
//  значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("b1 = ");
double bb1 = Convert.ToInt32(Console.ReadLine());
Console.Write("k1 = ");
double kk1 = Convert.ToInt32(Console.ReadLine());
Console.Write("b2 = ");
double bb2 = Convert.ToInt32(Console.ReadLine());
Console.Write("k2 = ");
double kk2 = Convert.ToInt32(Console.ReadLine());

double[] CoordinatePoint(double b1, double k1, double b2, double k2) 
{
    double[] point= new double[2];
    point[0] = (b2-b1)/(k1-k2);
    point[1] = k1*point[0]+b1;
    return point;
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]:F1}; ");
        else Console.Write($"{arr[i]:F1}");
    }
    Console.WriteLine("]");
}

void Check(double b1, double k1, double b2, double k2)
{
    if (k1 == k2) Console.WriteLine("Заданные прямые не пересекаются");
    else 
    {
        Console.Write("точка пересечения заданных прямых имеет координаты ");
        double[] coordinatePoint = CoordinatePoint(bb1,kk1,bb2,kk2);
        PrintArray(coordinatePoint);
    }
}

Check(bb1,kk1,bb2,kk2);


