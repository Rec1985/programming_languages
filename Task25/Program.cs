Console.Write("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("В какую степень возвести?: ");
int number2 = Convert.ToInt32(Console.ReadLine());

double result = Exponentiation(number1, number2);
Console.Write($"{number1}, {number2}  -> {result}");

double Exponentiation(int num1, int num2)
{
    return Math.Pow(num1, num2);
}