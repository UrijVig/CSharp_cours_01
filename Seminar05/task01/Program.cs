// int ReadInt(string text)
// {
//     System.Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int SumPositiv(int[] array)
// {
//     int sumPositiv = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0)
//         {
//             sumPositiv += array[i];
//         }
//     }
//     return sumPositiv;
// }
// int SumNegativ(int[] array)
// {
//     int sumNegativ = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] < 0)
//         {
//             sumNegativ += array[i];
//         }
//     }
//     return sumNegativ;
// }

void AddArray(int[] array)
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(-9, 10);
    }
}

void WriteArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

void SumNegativAndPositiv(int[] array, out int sumNegativ, out int sumPositiv)
{
    sumPositiv = 0;
    sumNegativ = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        {
            sumNegativ += array[i];
        }
        else
        {
            sumPositiv += array[i];
        }
    }
}

int[] array = new int[12];

AddArray(array);
WriteArray(array);
SumNegativAndPositiv(array, out int sumN, out int sumP);

System.Console.WriteLine($"Сумма положительных чисел: {sumP}");
System.Console.WriteLine($"Сумма отрицательных чисел: {sumN}");