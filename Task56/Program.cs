// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт 
//номер строки с наименьшей суммой элементов: 1 строка

int[,] createMatrixRndInt = CreateMatrixRndInt(3, 3, -10, 10);
PrintMatrix(createMatrixRndInt);

int numberElementMinRowsSumm = NumberElementMinRowsSumm(createMatrixRndInt);
Console.WriteLine($"Наименьшая сумма элементов в строке с индексом: [{numberElementMinRowsSumm}]");

int NumberElementMinRowsSumm(int[,] matrix)
{
    int minNumRows = 0;
    int[] temp = CreateArrayFromMatrixRows(matrix, 0);              // из строки[0] создаем одномерный массив  
    int summ = SummElementsArray(temp);                             // ищем сумму одномерного массива, присваиваем переменной как первое значение

    for (int i = 1; i < matrix.GetLength(0); i++)                   // итерация с единицы т.к. нулевое значение сохранено 
    {
        int[] tempArray = CreateArrayFromMatrixRows(matrix, i);        
        int summElementsArray = SummElementsArray(tempArray);
        if(summ > summElementsArray) 
        {
            minNumRows = i;
            summ = summElementsArray;
        }
    }
    return minNumRows;
}

int[] CreateArrayFromMatrixRows(int[,] matrix, int rows)
{
    int[] newArray = new int[matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(1); i++)
    {        
        newArray[i] = matrix[rows, i];
    }
    return newArray;
}

int SummElementsArray(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        result += array[i];
    }
    return result;
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
