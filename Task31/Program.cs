// Задача 31: 
// 1. Задайте массив из 12 элементов, 
// 2. заполненный случайными числами из промежутка [-9, 9]. 
// 3. Найдите сумму отрицательных и положительных элементов массива.

// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.

int[] array = CreateArrayRndInt(12, -9, 9);
PrintArray(array);
//--------------------------Вариант 1 -------------------------------------------------------
int[] sumNegativePositiveElement = GetSumNegativePositiveElement(array);
Console.WriteLine();
Console.WriteLine($"Сумма отрицательных элементов = {sumNegativePositiveElement[0]}");
Console.WriteLine($"Сумма положительных элементов = {sumNegativePositiveElement[1]}");
//--------------------------Вариант 2 - Разделение ответственности---------------------------
int sumNegative = GetSumNegativeElement(array);
int sumPositive = GetSumPositiveElement(array);
Console.WriteLine();
Console.WriteLine($"Сумма отрицательных элементов = {sumNegative}");
Console.WriteLine($"Сумма положительных элементов = {sumPositive}");

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max +1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
    }
    Console.Write("]");
}

int[] GetSumNegativePositiveElement(int[] arr)
{
    int sumNegative = 0;
    int sumPosotive = 0;
    for (int i = 0; i < arr.Length; i++) 
    {
      if(arr[i] < 0) sumNegative += arr[i];
      else sumPosotive += arr[i];
    }
    return new int[] {sumNegative, sumPosotive};
}

int GetSumNegativeElement(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++) 
    {
      if(arr[i] < 0) sum += arr[i];
    }
    return sum;
}

int GetSumPositiveElement(int[] arr)
{
   int sum = 0;
    for (int i = 0; i < arr.Length; i++) 
    {
      if(arr[i] > 0) sum += arr[i];
    }
    return sum;
}