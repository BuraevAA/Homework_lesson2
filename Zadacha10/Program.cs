Console.Clear();
void FillData(int[] Data)
{
    int Lenght = Data.Length;
    int i = 0;
    Console.WriteLine("Введите элемент трехзначного числа от 0 до 9");
    while (i < Lenght)
        {
            Data[i] = Convert.ToInt32(Console.ReadLine());
            i++;
        }
        for (i = 0; i < Lenght; i++)
        Console.Write(Data[i]);
}
int[] Data  = new int[3];
FillData(Data);
Console.WriteLine("");
Console.WriteLine("Второй элемент трехзначного числа :" +Data[1]);