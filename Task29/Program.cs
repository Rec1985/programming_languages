
Console.Write("Введите максимальное количество элементов в массиве: ");
int sizeArr = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение эллемента в массиве: ");
int valueArr = Convert.ToInt32(Console.ReadLine());

int[] mass = GenerateArray(sizeArr, valueArr);

PrintArray(mass);
Console.Write("->");
PrintArrayFormating(mass);

int[] GenerateArray(int size, int value)
{
    Random random = new Random();
    int[] arrNumbers = new int [size];
    for (int i = 0; i < arrNumbers.Length; i++)
    {
        arrNumbers[i] = random.Next(0, value);
    }
    return arrNumbers;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

void PrintArrayFormating(int[] inArr)
{
    Console.Write("[ ");
    for (int i = 0; i < inArr.Length; i++)
    {
        Console.Write($"{inArr[i]}");
        if(i < inArr.Length-1) Console.Write($", ");
    }
    Console.Write(" ]");
}