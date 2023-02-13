// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] createMatrixRndInt1 = CreateMatrixRndInt(5, 4, -10, 10);
PrintMatrix(createMatrixRndInt1);
Console.WriteLine("***********************");
int[,] createMatrixRndInt2 = CreateMatrixRndInt(4, 2, -10, 10);
PrintMatrix(createMatrixRndInt2);
Console.WriteLine("-----------------------");
PrintMatrixMultiplication(createMatrixRndInt1, createMatrixRndInt2);

void PrintMatrixMultiplication(int[,] matrix1, int[,] matrix2)
{
    if(matrix1.GetLength(1) == matrix2.GetLength(0))
    {
        int[,] matrixMultiplication = MatrixMultiplication(matrix1, matrix2);
        PrintMatrix(matrixMultiplication);
    }
    else Console.WriteLine("Перемножение матриц невозможно!");
}

int[,] MatrixMultiplication(int[,] multiplier1, int[,] multiplier2)// 2x3 3x5
{
    int[,] resultMatrix = new int[multiplier1.GetLength(0), multiplier2.GetLength(1)]; //2x5

    for (int i = 0; i < resultMatrix.GetLength(0); i++)  // massRows
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)  // massColumns
        {
            for (int k = 0; k < multiplier2.GetLength(0); k++)
            {
                resultMatrix[i , j] += multiplier1[i, k] * multiplier2[k, j];
            }                  
        }
    }
    return resultMatrix;
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

