System.Console.WriteLine("Введите X и Y первой точки");
int[] coordsA = Array.ConvertAll(Console.ReadLine()!.Split(" "), int.Parse);
System.Console.WriteLine("Введите X и Y второй точки");
int[] coordsB = Array.ConvertAll(Console.ReadLine()!.Split(" "), int.Parse);

double distance =Math.Sqrt(Math.Pow(coordsA[0]-coordsB[0],2) + Math.Pow(coordsA[1]-coordsB[1],2));

System.Console.WriteLine( "Расстояние между точками: " + Math.Round(distance,3));