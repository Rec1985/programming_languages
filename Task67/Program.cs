Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int  summNumbers = SummNumbers(num);
Console.WriteLine($"Сумма цифр числа равна: {summNumbers}");

int SummNumbers(int number)
{
    if(number == 0) return 0;
    else return number % 10 + SummNumbers(number /10);
}
