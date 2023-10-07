// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 46 -> 101110
// 13 -> 1101
// 2 -> 10



int DecToBaseNum(int num, int baseNum)
{
    int result = 0;
    int mult = 1;
    while (num > 0)
    {
        result += num % baseNum * mult;
        num /= 2;
        mult *= 10;
    }
    return result;
}

Console.WriteLine("Введите десятичное число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите систему исчисления");
int baseNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{DecToBaseNum(number,baseNumber)}");