// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите число M: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int numN = Convert.ToInt32(Console.ReadLine());


int summ = NaturalsNumbers(numM, numN);
Console.Write($" -> {summ}");

int NaturalsNumbers(int numberM, int numberN)
{
    if(numberM == numberN + 1) return 0;
    return numberM + NaturalsNumbers(numberM + 1, numberN);
}
