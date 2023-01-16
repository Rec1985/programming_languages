Console.WriteLine("--------------------ВЫВОД ЦЕЛЫХ ЧИСЕЛ В ПРОМЕЖУТКЕ ОТ -N ДО N--------------------");
Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
{
    int count = -number;
    if (count <= number)
    {
        Console.Write(count + " ");
        count++;
    }
}
else
{
    Console.WriteLine("Число должно быть больше нуля");
}

