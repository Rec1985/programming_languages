// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

bool isTetraTrue = IsTetraTrue (num1, num2, num3);

Console.WriteLine(isTetraTrue ? "Да" : "Нет");




bool IsTetraTrue (int a, int b, int c)
{
    return a < b + c && b < a + c && c < a + b;   
}