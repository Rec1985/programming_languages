// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = SignSumOfCells(number);
Console.Write($"{result}");

int SignSumOfCells(int num) //Сумирует ячейки числа с учётом знака
{
    bool flag = true;
    if(num < 0) //Если число отрицательное, преобразуем в положительное и ставим флажек
    {
        flag = false;
        num *= -1;
    }

    int summ = num%10;
    while (num > 0)
    {
        num = num / 10;
        summ += num%10;
    }

    if(flag == false) summ *= -1;//Если стоял флажек, преобразуем результат назад в отрицательное

    return summ;
}