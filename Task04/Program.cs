
Console.WriteLine("--------------------МАКСИМАЛЬНОЕ ЗНАЧЕНИЕ ИЗ ТРЁХ ЧИСЕЛ--------------------");
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;
if(max < num2){
    max = num2;
}
if(max < num3){
    max = num3;
}
Console.WriteLine($"Максимальное число: {max}");