Console.WriteLine("--------------------ВЫВОДИТ ЧЁТНОЕ ЛИ ЧИСЛО--------------------");
Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number%2 == 0){
    Console.WriteLine("Да");
}else{
    Console.WriteLine("Нет");
}