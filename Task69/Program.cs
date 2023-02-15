Console.WriteLine("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int power = PowerNumbers(numberA, numberB);
Console.WriteLine($"A в степени B: {power}");

int PowerNumbers(int num1, int num2)
{
    if(num2 == 0) return 1;
    else return num1 * PowerNumbers(num1, num2 -1);    
}