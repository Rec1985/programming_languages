// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.
int[]  genArray = CreateArrayRndInt(10, 0, 255);
PrintArray(genArray);
Console.WriteLine();

int[] newArr = CopyArray (genArray);
newArr[3] = -1;
PrintArray(newArr);
Console.WriteLine();
PrintArray(genArray);

int[] CopyArray (int[] mass)
{
    int[] newArray = new int[mass.Length];
    for (int i = 0; i < mass.Length; i++)
    {
        newArray[i] = mass[i];
    }
    return newArray;
}

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
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}


