// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

const int numK = 0;
const int numB = 1;

double[] InputData()
{
    double[] arr = new double[2];
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.WriteLine($"Введите {i + 1}-й элемент {i + 1}-го уравнения:");
        arr[i] = Convert.ToDouble(Console.ReadLine());
    }
    return arr;
}

double[] FindePoint(double[] one, double[] two)
{
    double[] coord = new double[2];
    coord[0] = (one[numB] - two[numB]) / (two[numK] - one[numK]);
    coord[1] = two[numK] * coord[0] + two[numB];
    return coord;
}

System.Console.WriteLine("Прямые заданы уравнением: y = k * x + b \nk - первый элемент, b - второй элемент.");
double[] lineOne = InputData();
double[] lineTwo = InputData();
double[] coord = FindePoint(lineOne, lineTwo);
System.Console.WriteLine($"прямы пересекаются в точке X:{coord[0]} и Y:{coord[1]}.");
