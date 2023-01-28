// Задача 34: Задайте массив заполненный случайными  
// положительными трёхзначными числами. Напишите программу,  
// которая покажет количество чётных чисел в массиве. 
// [345, 897, 568, 234] -> 2 

int[] mass = CreateArrayRndInt(10, 100, 999);
PrintArray(mass);
int result = CountEvenNumbers(mass);
Console.Write(" -> ");
Console.Write(result);

int CountEvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    return count;
}

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] massive)
{
    Console.Write("[");
    for (int i = 0; i < massive.Length; i++)
    {
        if (i < massive.Length - 1) Console.Write($"{massive[i]}, ");
        else Console.Write($"{massive[i]}");
    }
    Console.Write("]");
}