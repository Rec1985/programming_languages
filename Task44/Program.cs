// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
Console.Write("Введите натуральное число: ");
int num = Convert.ToInt32(Console.ReadLine());

int[] result = FibonacciArray(num);
PrintArray(result);

int[] FibonacciArray(int number)
{

    int[] fiboArray = new int[number];
    fiboArray[0] = 0;
    fiboArray[1] = 1;
    for (int i = 2; i < number; i++)
    {
        fiboArray[i] = fiboArray[i-2] + fiboArray[i-1];
    }
    return fiboArray;
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