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

int DiagonaleSum(int[,] matr)
{
    int sum = 0;
    for (int i = 0; i < matr.GetLength(0) && i < matr.GetLength(1); i++)
    {
        sum += matr[i, i];
    }
    return sum;
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
int sum = DiagonaleSum(matrix);
System.Console.WriteLine($"Сумма главной диагонали равна: {sum}");