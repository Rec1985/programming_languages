
Console.Write("Введите целое полоительое число: ");
int number = Convert.ToInt32( Console.ReadLine());

int sumNumbers = SumNumber(number);
Console.WriteLine($"Сумма чисел от 1 до {number} = {sumNumbers}");

int SumNumber(int num)
{
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
        sum += i;
    }
    return sum;
}
