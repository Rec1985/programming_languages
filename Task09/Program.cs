// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random().Next(10, 100);
Console.WriteLine($"Сгенерированное число ->{number}");
int maxDigit = MaxDigit(number);
Console.WriteLine($"Случайное число из отрезка 10 - 99 -> {maxDigit}");

int MaxDigit(int number)
{
    int firstDigit = number / 10;
    int secondDigit = number % 10;
    int result = firstDigit > secondDigit ? firstDigit : secondDigit;
    return result;
}