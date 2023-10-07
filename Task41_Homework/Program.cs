// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


int[] CreateArray(int size)
{
    Console.WriteLine("Введите элементы массива");
    int[] arr = new int[size];
    for (int i=0; i<size; i++)
    {
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

int CountPositiveElems(int[] arr)
{
    int count = 0;
    for (int i=0; i<arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;
}


Console.WriteLine("Сколько чисел вы хотите ввести?");
int sizeArray = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(sizeArray);
int result = CountPositiveElems(array);
PrintArray(array);
Console.WriteLine($"Количество положительных элементов в массиве -> {result}");