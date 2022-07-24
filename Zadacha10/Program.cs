Console.Clear();
Console.WriteLine("Введите три числа от 0 до 9: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int[] array = { a, b, c };
Console.WriteLine($"{array[0]}{array[1]}{array[2]}");
Console.WriteLine($"{array[1]}");

