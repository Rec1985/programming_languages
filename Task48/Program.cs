// Задача 48: Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится по формуле: Amn = m+n. 
// Выведите полученный массив на экран. 
// m = 3, n = 4. 
// 0 1 2 3 
// 1 2 3 4 
// 2 3 4 5

int[,] result = ReplaceMatrix(5, 5);
PrintMatrix(result);

int[,] ReplaceMatrix(int colums, int rows)
{
    int[,] mass = new int[colums, rows];
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            mass[i, j] = i + j;           
        }
    }
    return mass;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4} | ");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}

