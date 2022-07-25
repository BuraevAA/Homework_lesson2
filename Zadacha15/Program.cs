Console.Clear();
Console.WriteLine("Введите число, соответствующе дню недели: ");
int num = Convert.ToInt32(Console.ReadLine());
string a = "Да, это выходной день!";
string b = "Нет, увы это будний день!";
if(num >= 1 && num <= 5)
{
    Console.Write($"{num} {b}");
}
else if(num >= 6 && num <= 7)
{
    Console.Write($"{num} {a}");
}


