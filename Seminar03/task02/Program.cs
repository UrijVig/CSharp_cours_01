System.Console.Write("Введите координату X: ");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координату Y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0)
    System.Console.WriteLine("Точка находится в 1 четверти");
else if (x < 0 && y > 0)
    System.Console.WriteLine("Точка находится в 2 четверти");
else if (x < 0 && y < 0)
    System.Console.WriteLine("Точка находится в 3 четверти");
else if (x > 0 && y < 0)
    System.Console.WriteLine("Точка находится в 4 четверти");
else 
    System.Console.WriteLine("точка лежит на осях");