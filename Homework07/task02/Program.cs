// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rand = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = rand.Next(0, 10);
        }
    }
    return matrix;
}

int ElementSearch(int[,] matr)
{
    int line;
    int pillar;
    while (true)
    {
        line = ReadInt("Введите номер строки: ");
        if (line < matr.GetLength(0) + 1) break;
        else System.Console.WriteLine("Введённое число не соответсвует условиям поиска, повторите попытку!");
    }
    while (true)
    {
        pillar = ReadInt("Введите номер столбца: ");
        if (pillar < matr.GetLength(1) + 1) break;
        else System.Console.WriteLine("Введённое число не соответсвует условиям поиска, повторите попытку!");
    }

    return matr[line - 1, pillar - 1];
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write(matr[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

int m = ReadInt("Введите количество строк: ");
int n = ReadInt("Введите количество столбцов: ");

var matrix = GenerateMatrix(m, n);
PrintMatrix(matrix);
System.Console.WriteLine($"Искомый вами элемент: {ElementSearch(matrix)}");