// Task10: 
//     Напишите программу, которая 
//     принимает на вход трёхзначное число и на 
//     выходе показывает вторую цифру этого числа. 
//     Выполнить с помощью числовых операций 
//     (целочисленное деление, остаток от деления).

//     456 -> 5
//     782 -> 8
//     918 -> 1

Console.WriteLine("--------------------ПРИНИМАЕТ ТРЁХЗНАЧНОЕ ЧИСЛО, ВЫВОДИТ ВТОРУЮ ЦИФРУ--------------------");

Console.Write("Введите число от 100 до 999: ");
int number = Convert.ToInt32(Console.ReadLine());
//int result = ConvertThreeToOne(number);

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




