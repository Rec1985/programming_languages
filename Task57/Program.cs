// Array.Sort(array);
// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.
int[,] matrix = CreateMatrixRndInt(5, 5, 0, 9);
PrintMatrix(matrix);
Console.WriteLine();

int[] array = MatrixToArray(matrix);
Array.Sort(array);
PrintArray(array);
Console.WriteLine();
FrequencyDictionary(array);


void FrequencyDictionary(int[] inArray)
{
    int count = 1;
    int num = inArray[0];
    for (int i = 1; i < inArray.Length; i++)
    {         
        if(inArray[i] == num)
        {
            count++;
        }
        else 
        {
            Console.WriteLine($"{num} -> {count}");
            count = 1;
            num = inArray[i];
        }      
    
    }
    Console.WriteLine($"{num} -> {count}");
}

int[] MatrixToArray(int[,] inMatrix)
{
    int[] outArray = new int[inMatrix.Length];
    int count  = 0;
    for (int i = 0; i < inMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inMatrix.GetLength(1); j++)
        {
            outArray[count] = inMatrix[i, j];
            count++;
        }
    }
    return outArray;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4} ");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }

}

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }

    }
    return matrix;
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




























