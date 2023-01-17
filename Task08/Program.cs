
Console.WriteLine("--------------------ПОКАЗЫВАЕТ ВСЕ ЧЁТНЫЕ ЧИСЛА ОТ 1 ДО N--------------------");
Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;
while (count <= number)
{
    if (count % 2 == 0)
    {
        Console.Write($"{count} ");
    }
    count++;
}