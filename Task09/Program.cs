
Console.WriteLine("--------------------ПОКАЗЫВАЕТ НАИБОЛЬШУЮ ЦИФРУ ЧИСЛА--------------------");

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