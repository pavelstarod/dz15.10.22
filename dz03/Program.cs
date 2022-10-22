// Написать программу копирования массива

int[] mas1 = { 14, 3, 9, 5, 12, 3, 4, 5 };

void PrintMas1(int[] array)
{
    for (int count = 0; count < mas1.Length; count++)
    {
        Console.Write(mas1[count] + "  ");
    }
}
Console.WriteLine("Вывод первого массива: ");
PrintMas1(mas1);
Console.WriteLine();

int[] mas2 = new int[mas1.Length];
for (int i = 0; i < mas1.Length; i++)
{
    mas2[i] = mas1[i];
}

void PrintMas2(int[] arr)
{
    for (int ind = 0; ind < arr.Length; ind++)
    {
        Console.Write(mas2[ind] + "  ");
    }
}

Console.WriteLine("Вывод копии массива: ");
PrintMas2(mas2);
