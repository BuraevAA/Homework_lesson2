Console.Clear();
Console.WriteLine("Введите количество элементов числа");
int n = Convert.ToInt32(Console.ReadLine());
void FillData(int[] Data)
{
    int Lenght = Data.Length;
    int i = 0;
    Console.WriteLine("Введите элемент числа от 0 до 9");
    while (i < Lenght)
        {
            Data[i] = Convert.ToInt32(Console.ReadLine());
            i++;
        }
        for (i = 0; i < Lenght; i++)
        Console.Write(Data[i]);
}
int[] Data  = new int[n];
FillData(Data);
if(n >= 3)
{
    Console.WriteLine("");
    Console.WriteLine("Третий элемент числа :" +Data[2]);
}
else
{
    Console.WriteLine("");
    Console.WriteLine("Третий элемент числа отсутствует");
}

