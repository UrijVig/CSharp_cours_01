// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
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
            matrix[i, j] = rand.Next(1, 10);
        }
    }
    return matrix;
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

int[,] MultipliMatrix(int[,] matrI, int[,] matrJ)
{
    int[,] multy = new int[matrI.GetLength(0), matrJ.GetLength(1)];
    for (int i = 0; i < multy.GetLength(0); i++)
    {
        for (int j = 0; j < multy.GetLength(1); j++)
        {
            for (int k = 0; k < matrJ.GetLength(0); k++)
            {
                multy[i, j] = multy[i, j] + matrI[i, k] * matrJ[k, j];
            }
        }
    }
    return multy;
}


int m = ReadInt("Введите количество строк первой матрицы: ");
int n = ReadInt("Введите количество столбцов первой матрицы: ");

var myMatrix = GenerateMatrix(m, n);

while (true)
{
    m = ReadInt("Введите количество строк второй матрицы: ");
    if (m == n) break;
    else System.Console.WriteLine("Количество строк второй матрицы должно совпадать с количеством столбцов первой!");
}
n = ReadInt("Введите количество столбцов второй матрицы: ");
var newMatrix = GenerateMatrix(m, n);
System.Console.WriteLine("Первая матрица: ");
PrintMatrix(myMatrix);
System.Console.WriteLine("Вторая матрица: ");
PrintMatrix(newMatrix);

System.Console.WriteLine("Производная от перемножения матрица: ");
var multiMatrix = MultipliMatrix(myMatrix, newMatrix);
PrintMatrix(multiMatrix);