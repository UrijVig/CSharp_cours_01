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

// void FindNumbers(int[,] matr)
// {
//     int number = 1;
//     int count;
//     while (number < 10)
//     {
//         count = 0;
//         for (int i = 0; i < matr.GetLength(0); i++)
//         {
//             for (int j = 0; j < matr.GetLength(1); j++)
//             {
//                 if (matr[i, j] == number) count++;
//             }
//         }
//         System.Console.WriteLine($"количество {number} в матрице = {count}");
//         number++;
//     }
// }

int[] FindNumbers(int[,] matr)
{
    int[] counter = new int[9];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            counter[matr[i, j] - 1]++;
        }
    }
    return counter;

}

void PrintResult(int[] counter)
{
    for (int i = 0; i < counter.Length; i++)
    {
        if (counter[i] != 0)
        {
            System.Console.WriteLine($"{i + 1} встречается {counter[i]} раз");
        }
    }
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
var result = FindNumbers(matrix);
PrintResult(result);
