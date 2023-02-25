// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

System.Console.WriteLine("Введите X Y Z первой точки");
int[] coordsA = Array.ConvertAll(Console.ReadLine()!.Split(" "), int.Parse);
System.Console.WriteLine("Введите X Y Z второй точки");
int[] coordsB = Array.ConvertAll(Console.ReadLine()!.Split(" "), int.Parse);

double distance = Math.Sqrt(Math.Pow(coordsA[0] - coordsB[0], 2) + Math.Pow(coordsA[1] - coordsB[1], 2) + Math.Pow(coordsA[2] - coordsB[2], 2));

System.Console.WriteLine("Расстояние между точками: " + Math.Round(distance, 2));