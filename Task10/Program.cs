
Console.WriteLine("--------------------ПРИНИМАЕТ ТРЁХЗНАЧНОЕ ЧИСЛО, ВЫВОДИТ ВТОРУЮ ЦИФРУ--------------------");

Console.Write("Введите число от 100 до 999: ");
int number = Convert.ToInt32(Console.ReadLine());

if(ConvertThreeToOne(number) == -1)
    Console.WriteLine("Введено не верное значение!");
else Console.WriteLine(ConvertThreeToOne(number));

int ConvertThreeToOne(int num)
{
    
    if (100 <= num && num < 1000)
    {
        return num/10%10;
    }
    else
        return -1;
}




