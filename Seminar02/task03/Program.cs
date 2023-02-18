// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

Console.Write("Введите число №1: ");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число №2: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());

if (numberTwo % numberOne == 0 )
    System.Console.WriteLine($"Второе число кратно первому: ");
else 
    System.Console.WriteLine($"Второе число не кратно первому, остаток от деления = {numberTwo % numberOne} ");