// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    int count = 0;
    while (count <= matrix.GetLength(0) * matrix.GetLength(1))
    {
        for (int j = matrix.GetLength(1) - n; j < n; j++)
        {
            count++;
            matrix[matrix.GetLength(0) - m, j] = count;
        }
        if (count >= matrix.GetLength(0) * matrix.GetLength(1)) break;
        for (int i = matrix.GetLength(0) - m + 1; i < m - 1; i++)
        {
            count++;
            matrix[i, n - 1] = count;
        }
        if (count >= matrix.GetLength(0) * matrix.GetLength(1)) break;
        for (int j = n - 1; j > matrix.GetLength(1) - n; j--)
        {
            count++;
            matrix[m - 1, j] = count;
        }
        if (count >= matrix.GetLength(0) * matrix.GetLength(1)) break;
        for (int i = m - 1; i > matrix.GetLength(0) - m; i--)
        {
            count++;
            matrix[i, matrix.GetLength(1) - n] = count;
        }
        if (count >= matrix.GetLength(0) * matrix.GetLength(1)) break;
        n--;
        m--;
    }
    return matrix;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write(matr[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int m = ReadInt("Введите количество строк матрицы: ");
int n = ReadInt("Введите количество столбцов матрицы: ");

var myMatrix = GenerateMatrix(m, n);
PrintMatrix(myMatrix);