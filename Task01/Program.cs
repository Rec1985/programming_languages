﻿Console.WriteLine("--------------------ЯВЛЯЕТСЯ ЛИ ПЕРВОЕ КВАДРАТОМ ВТОРОГО--------------------");
Console.Write("Введите первое натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе натуральное число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if(number == number2 * number2)
{
    Console.WriteLine("Да");
}else{
    Console.WriteLine("Нет");
}