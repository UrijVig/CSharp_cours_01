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

int[] FindMinimal(int[,] matr)
{

    int[] minimalCoord = new int[3];
    minimalCoord[0] = matr[0, 0];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (minimalCoord[0] > matr[i, j])
            {
                minimalCoord[0] = matr[i, j];
                minimalCoord[1] = i;
                minimalCoord[2] = j;
            }
        }
    }
    return minimalCoord;
}

// int[,] DeleteMinimalCoord(int[,] matr, int[] minimalCoord)
// {
//     int[,] result = new int[matr.GetLength(0) - 1, matr.GetLength(1) - 1];
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             if (i == minimalCoord[1] || j == minimalCoord[2]) continue;
//             else if (i > minimalCoord[1]) result[i - 1, j] = matr[i, j];
//             else if (j > minimalCoord[2]) result[i, j - 1] = matr[i, j];
//             else if (i > minimalCoord[1] && j > minimalCoord[2]) result[i - 1, j - 1] = matr[i, j];
//             else result[i, j] = matr[i, j];
//         }
//     }
//     return result;
// }

int[,] DeleteMinimalCoord(int[,] matr, int[] minimalCoord)
{
    int[,] result = new int[matr.GetLength(0) - 1, matr.GetLength(1) - 1];
    int ii = 0;
    int jj = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        if (i == minimalCoord[1]) continue;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (j == minimalCoord[2]) continue;
            result[ii, jj] = matr[i, j];
            jj++;
        }
        ii++;
        jj = 0;
    }
    return result;
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
var minimal = FindMinimal(matrix);
System.Console.WriteLine();
var resultMatrix = DeleteMinimalCoord(matrix, minimal);
PrintMatrix(resultMatrix);

