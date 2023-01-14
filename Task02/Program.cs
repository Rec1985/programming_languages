
Console.WriteLine("--------------------КАКОЕ ЧИСЛО БОЛЬШЕ, А КАКОЕ МЕНЬШЕ--------------------");

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2){
    Console.Write($"Число {num1} больше, а {num2} меньше!");
}else if(num2 > num1){
    Console.Write($"Число {num2} больше, а {num1} меньше!");
}else{
    Console.Write("Числа равны!");
} 




