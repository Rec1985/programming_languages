// Task08: 
//     Напишите программу, которая на вход принимает число (N), 
//     а на выходе показывает все чётные числа от 1 до N.

//     5 -> 2, 4
//     8 -> 2, 4, 6, 8
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