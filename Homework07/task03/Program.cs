// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

double[] Average(int[,] matr)
{
    double[] arr = new double[matr.GetLength(1)];
    for (int i = 0; i < matr.GetLength(1); i++)
    {
        for (int j = 0; j < matr.GetLength(0); j++)
        {
            arr[i] += matr[j,i];
        }
        arr[i] /= matr.GetLength(0);
    }
    return arr;
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
void WriteArray(double[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

int m = ReadInt("Введите количество строк: ");
int n = ReadInt("Введите количество столбцов: ");

var matrix = GenerateMatrix(m, n);
PrintMatrix(matrix);
var averageArray = Average(matrix);
System.Console.WriteLine("среднее арифметическое каждого столбца соответственно:");
WriteArray(averageArray);
