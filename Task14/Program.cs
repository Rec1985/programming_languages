
Console.WriteLine("--------------------ПРИНИМАЕТ ЧИСЛО, ПРОВЕРЯЕТ КРАТНО ОНО 7 И 23?--------------------");

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if(ComplexMultiplicity(number))
Console.WriteLine("Да");
else 
Console.WriteLine("Нет"); 

bool ComplexMultiplicity(int num)
{
    return num % 7 == 0 && num % 23 == 0 ? true : false; 
}
