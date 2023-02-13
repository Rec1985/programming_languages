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
int[,] matrix = CreateMatrixRndInt(4, 4, 0, 25);
PrintMatrix(matrix);
Console.WriteLine();
int[] massIndexessMinElement = MassIndexessMinElement(matrix);
int[,] newMatrix = DeliteMinRowsColums(matrix, massIndexessMinElement);
PrintMatrix(newMatrix);

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

int[] MassIndexessMinElement(int[,] inMatrix)
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




///////////////////////
// void IncorrectValue()
// {
//     Console.WriteLine("Введено некорректное значение.");
//     Environment.Exit(0);
// }

// int UserInput()
// {
//     if (!int.TryParse(Console.ReadLine(), out int temp)) IncorrectValue();
//     return temp;
// }

// int[,] MatrixCreate(int rows, int columns, int min, int max)
// {
//     int[,] array = new int[rows, columns];
//     Random rnd = new Random();
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i, j] = rnd.Next(min, max + 1);
//         }
//     }
//     return array;
// }


// int[] MatrixMinElemIndex(int[,] array2D)
// {
//     int[] result = new int[2];
//     int min = array2D[0, 0];
//     for (int i = 0; i < array2D.GetLength(0); i++)
//     {
//         for (int j = 0; j < array2D.GetLength(1); j++)
//         {
//             if (array2D[i, j] < min)
//             {
//                 min = array2D[i, j];
//                 result[0] = i;
//                 result[1] = j;
//             }
//         }
//     }
//     return result;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i < array.Length - 1)
//             Console.Write($"{array[i]}; ");
//         else Console.WriteLine($"{array[i]}.");
//     }
// }

// int[,] DeleteMinRowsColumns(int[,] array2D, int[] array)
// {
//     int rowsCount = array2D.GetLength(0) - 1;
//     int columnsCount = array2D.GetLength(1) - 1;
//     int[,] resultMatrix = new int[rowsCount, columnsCount];
//     int m = 0;
//     for (int i = 0; i < rowsCount; i++)
//     {
//         if (m == array[0]) m++;
//         int n = 0;
//         for (int j = 0; j < columnsCount; j++)
//         {
//             if (n == array[1]) n++;
//             resultMatrix[i, j] = array2D[m, n];
//             n++;
//         }
//         m++;
//     }
//     return resultMatrix;
// }

// Console.Write("Введите кол-во строк в массиве: ");
// int rowsSize = UserInput();
// if (rowsSize <= 0) IncorrectValue();
// Console.Write("Введите кол-во столбцов в массиве: ");
// int columnsSize = UserInput();
// if (columnsSize <= 0) IncorrectValue();
// Console.Write("Введите левую границу диапазона чисел: ");
// int minValue = UserInput();
// Console.Write("Введите правую границу диапазона чисел: ");
// int maxValue = UserInput();

// int[,] matrix = MatrixCreate(rowsSize, columnsSize, minValue, maxValue);
// Console.WriteLine("Заданный массив:");
// PrintMatrix(matrix);

// int[] indexArray = MatrixMinElemIndex(matrix);
// Console.Write("Индекс минимального элемента: ");
// PrintArray(indexArray);

// int[,] answerMatrix = DeleteMinRowsColumns(matrix, indexArray);
// Console.WriteLine("Результирующий массив:");
// PrintMatrix(answerMatrix);