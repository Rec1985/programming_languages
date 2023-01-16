
Console.WriteLine("--------------------ПОСЛЕДНЯЯ ЦИФРА ТРЁХЗНАЧНОГО ЧИСЛА--------------------");
Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number/100 > 0 && number/100 < 10)
{
    int result = number % 10;
    Console.Write($"Последнее число: {result}");
}else{
    Console.WriteLine("Вы ввели не трёхзначное число!");
}
