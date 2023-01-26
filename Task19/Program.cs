// Task19:
//     Напишите программу, которая принимает на вход пятизначное число 
//     и проверяет, является ли оно палиндромом.

//     14212 -> нет
//     12821 -> да
//     23432 -> да

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
  


if(number > 9999 && number < 100000)
{
    String result = IsPolyndrom(number);
    Console.WriteLine($"{number} -> {result}");
}else{
    Console.WriteLine($"Введено не корректное значение!");
}



String IsPolyndrom(int num) //12345
{
    if(num < 0) num *= -1;
    
    int a, b, c, d, e, revers;
    a = num%10;
    b = num/10%10;
    c = num/100%10;
    d = num/1000%10;
    e = num/10000%10;

    revers = e*1 + d*10 + c*100 + b*1000 + a*10000;

    if(num == revers) return "Да";
    else return "Нет";
}