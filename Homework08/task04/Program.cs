// Сформируйте трёхмерный массив двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,,] GenerateMatrix(int x, int y, int z)
{
    int[,,] matrix = new int[x, y, z];
    Random rand = new Random();
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                matrix[i, j, k] = rand.Next(1, 10);
            }
        }
    }
    return matrix;
}

void PrintMatrix(int[,,] matr)
{

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                System.Console.Write($"{matr[i,j,k]}({i},{j},{k}) ");
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine();
    }    
}


int x = ReadInt("Введите значение X: ");
int y = ReadInt("Введите значение Y: ");
int z = ReadInt("Введите значение Z: ");

var myMatrix = GenerateMatrix(x, y, z);

PrintMatrix(myMatrix);