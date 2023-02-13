// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7
int[,] matrix = CreateMatrixRndInt(4, 5, 0, 255);
PrintMatrix(matrix);
Console.WriteLine();



int[,] DeliteMinRowsColums(int[,] arrayMatrix, int[] array)
{
    int rowsCount = arrayMatrix.GetLength(0) - 1;
    int columnsCount = arrayMatrix.GetLength(1) - 1;
    int[,] resultMatrix = new int[rowsCount, columnsCount];
    int m = 0;
    for (int i = 0; i < rowsCount; i++)
    {
        if (m == array[0]) m++;
        int n = 0;
        for (int j = 0; j < columnsCount; j++)
        {
            if (n == array[1]) n++;
            resultMatrix[i, j] = arrayMatrix[m, n];
            n++;
        }
        m++;
    }
    return resultMatrix;
}


int[] IndexesMinElement(int[,] inMatrix)
{
    int indexRows = 0;
    int indexColumns = 0;
    int numbers = inMatrix[0, 0];
    for (int i = 0; i < inMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inMatrix.GetLength(1); j++)
        {
            if (inMatrix[i, j] < numbers)
            {
                numbers = inMatrix[i, j];
                indexRows = i;
                indexColumns = j;
            }
        }
    }
    return new int[] { indexRows, indexColumns };
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
