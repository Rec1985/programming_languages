// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Write("Введите значение - какое количество цифр будете вводить: ");
int countNums = Convert.ToInt32(Console.ReadLine());

int[] queryValue = QueryValue(countNums);
PrintArray(queryValue);
int resultSum = SumOfPositiveNumbers(queryValue);
Console.Write($" -> {resultSum}");


int[] QueryValue(int numCount)
{
    int query;
    int[] mass = new int[numCount]; 
    for (int i = 0; i < numCount; i++)
    {
        Console.Write($"Введите значение № {i + 1}:");
        query = Convert.ToInt32(Console.ReadLine());
        mass[i] = query;
    }
    return mass;
}

int SumOfPositiveNumbers(int[] inMass)
{
    int sum = 0;
    for (int i = 0; i < inMass.Length; i++)
    {
        if(inMass[i] > 0) sum += inMass[i];
    }
    return sum;
}

// int SumOfNegativeNumbers(int[] inMass)
// {
//     int sum = 0;
//     for (int i = 0; i < inMass.Length; i++)
//     {
//         if(inMass[i] < 0) sum += inMass[i];
//     }
//     return sum;
// }

void PrintArray (int[] massive) 
{ 
    Console.Write("["); 
    for (int i = 0; i < massive.Length; i++) 
    { 
        if(i < massive.Length - 1) Console.Write($"{massive[i]}, "); 
        else Console.Write($"{massive[i]}"); 
    } 
    Console.Write("]"); 
}