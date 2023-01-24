Console.Write("Введите номер четверти: ");
string numQuarter = Console.ReadLine();
string result = RangeCoordinates(numQuarter);
Console.WriteLine(result);

string RangeCoordinates(string cordinate)
{
    if(cordinate == "1") return ("x > 0, y > 0");
    if(cordinate == "2") return ("x < 0, y > 0");
    if(cordinate == "3") return ("x < 0, y < 0");
    if(cordinate == "4") return ("x > 0, y < 0");
    return ("Введите корректные данные!");
};