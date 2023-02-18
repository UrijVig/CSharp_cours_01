Console.Write("Введите первое число число: ");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число число: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());
if ((numberTwo * numberTwo) == numberOne)
    Console.WriteLine($"{numberOne} является квадратом числа {numberTwo}" );
else
    Console.WriteLine($"{numberOne} не является квадратом числа {numberTwo}" );




