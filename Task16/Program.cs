
Console.WriteLine("--------------------ПРИНИМАЕТ ДВА ЧИСЛА, ПРОВЕРЯЕТ ЯВЛЯЕТСЯ ЛИ ОДНО КВАДРАТОМ ДРУГОГО--------------------");
Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 * number1 == number2 || number2 * number2 == number1)
    Console.WriteLine("да");
else
    Console.WriteLine("Нет");
