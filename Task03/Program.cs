Console.WriteLine("--------------------НАЗВАНИЕ ДНЯ НЕДЕЛИ ПО ЗАДАННОМУ НОМЕРУ--------------------");
Console.WriteLine("Введите натуральное число от 1 до 7");
int numberWeek = Convert.ToInt32(Console.ReadLine());


if(numberWeek == 1){
    Console.Write("1 -> Понедельник");
}else if (numberWeek == 2){
    Console.Write("2 -> Вторник");
}else if (numberWeek == 3){
    Console.Write("3 -> Среда");
}else if (numberWeek == 4){
    Console.Write("4 -> Четверг");
}else if (numberWeek == 5){
    Console.Write("5 -> Пятница");
}else if (numberWeek == 6){
    Console.Write("6 -> Суббота");
}else if (numberWeek == 7){
    Console.Write("7 -> Воскресение");
}else{
    Console.Write($"{numberWeek} -> Вы ввели недопустимое значение!");
}
Console.WriteLine();