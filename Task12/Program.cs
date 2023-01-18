
Console.WriteLine("--------------------ПРИНИМАЕТ ДВА ЧИСЛА, ПРОВЕРЯЕТ ПЕРВОЕ КРАТНО ВТОРОМУ?--------------------");

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Multiplicity(num1, num2);

void Multiplicity(int arg1, int arg2)
{
    if(arg1 % arg2 == 0 )   Console.WriteLine($"Число {arg1} кратно {arg2}");
    else                    Console.WriteLine($"Число {arg1} не кратно {arg2} остаток = {arg1 % arg2}");
}