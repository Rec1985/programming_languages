// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.

int[,] matrix = CreateMatrixRndInt(4, 5, 0, 255);
PrintMatrix(matrix);
Console.WriteLine();
ReplacementMatrix(matrix);
PrintMatrix(matrix);

void ReplacementMatrix(int[,] matrixMassIn)
{    
    for (int i = 0; i < matrixMassIn.GetLength(1); i++)
    {
        int temp = matrixMassIn[0,i];
        matrixMassIn[0,i] = matrixMassIn[matrixMassIn.GetLength(0)-1,i];
        matrixMassIn[matrixMassIn.GetLength(0)-1,i] = temp;
    }
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