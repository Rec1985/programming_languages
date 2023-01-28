// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21
int[] mass = CreateArrayRndInt(6, 0, 12);
PrintArray(mass);
Console.WriteLine();
int[] result = Multiply(mass);
PrintArray(result);


int[] Multiply(int[] arr)
{
    int size = arr.Length%2 ==0 ?  arr.Length/2 : arr.Length/2 + 1;
    int[] arrResult = new int[size];
    for (int i = 0; i < size; i++)
    {
        int variable = arr.Length - i -1;
        if(i == variable)
        {
            arrResult[i] = arr[i];
            return arrResult;
        }
        arrResult[i] = arr[i] * arr[variable];
    }
    return arrResult;
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