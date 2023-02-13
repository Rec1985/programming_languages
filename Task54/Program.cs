// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой 
// строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int rowsMatrix = 4, columnsMatrix = 5, minMatrix = 0, maxMatrix = 255;
int[,] createMatrixRndInt = CreateMatrixRndInt(rowsMatrix, columnsMatrix, minMatrix, maxMatrix);
PrintMatrix(createMatrixRndInt);
Console.WriteLine("----------------------");
int[,] ResultMatrix = RegulateMatrixRowsDown(createMatrixRndInt);
PrintMatrix(createMatrixRndInt);

int[,] RegulateMatrixRowsDown(int[,] inMatrix)              // Упорядочивание элементов строк матрицы по убыванию
{
    for (int i = 0; i < inMatrix.GetLength(0); i++)
    {
        int[] array = MatrixToArrayFromRows(inMatrix, i);   // Создал одномерный масив из двухмерного
        SortDownArray(array);                               // Одномерный массив отсортирован по убыванию
        MergerArrayToMatrixFromRows(array, inMatrix, i);    // Слияние массивов       
    }
    return inMatrix;
}

int[] MatrixToArrayFromRows(int[,] inMatrix, int rows)
{
    int[] newOutArray = new int[inMatrix.GetLength(1)];
    for (int i = 0; i < inMatrix.GetLength(1); i++)
    {
        newOutArray[i] =  inMatrix[rows, i];
    }
    return newOutArray;
}

void SortDownArray(int[] inArray)
{
    bool sorted = false;
    while(!sorted) 
    {
        sorted = true;
        for (int i = 0; i < inArray.Length - 1; i++) 
        {
            if (inArray[i] < inArray[i+1])               
            {
                int temp = inArray[i];
                inArray[i] = inArray[i+1];
                inArray[i+1] = temp;
                sorted = false;
            }
        }
    }
}

void MergerArrayToMatrixFromRows(int[] inArray, int[,] inMatrix, int rows)
{
    if(inArray.Length == inMatrix.GetLength(1))
    {
        
        for (int i = 0; i < inMatrix.GetLength(1); i++)
        {
            inMatrix[rows, i] = inArray[i];
        }
    }
    else
    {
        Console.WriteLine("Ошибка слияния массивов!");
    }    
}

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns]; // 0, 1
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