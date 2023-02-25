// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

System.Console.Write("Пожалуйста введите пятизначное число:");
string? input = Console.ReadLine();
int[] inputArr = new int[input.Length];
int[] reverseArr = new int[input.Length];
int count = 0;
for (int i = 0; i < input.Length; i++)
{
    inputArr[i] = Convert.ToInt32(Convert.ToString(input[i]));
    reverseArr[input.Length - 1 - i] = Convert.ToInt32(Convert.ToString(input[i]));
}

for (int i = 0; i < input.Length; i++)
{
    if (reverseArr[i] == inputArr[i])
        count++;
}

if (count++ == input.Length)
    System.Console.WriteLine("Число является полинромом!");
else
    System.Console.WriteLine("Число не является полинромом!");