// Task14:
//     Напишите программу, которая принимает на
//     вход число и проверяет, кратно ли оно
//     одновременно 7 и 23.

//     14 -> нет
//     46 -> нет
//     161 -> да

Console.WriteLine("--------------------ПРИНИМАЕТ ЧИСЛО, ПРОВЕРЯЕТ КРАТНО ОНО 7 И 23?--------------------");

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
//bool resultBoolean = ComplexMultiplicity(number);
if(ComplexMultiplicity(number))
Console.WriteLine("Да");
else 
Console.WriteLine("Нет"); 


bool ComplexMultiplicity(int num)
{
    return num % 7 == 0 && num % 23 == 0 ? true : false; 
}
