// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] AddArray()
{
    System.Console.WriteLine("Введите энное количество чисел через пробел: ");
    int[] array = Array.ConvertAll(Console.ReadLine()!.Split(" "), int.Parse);
    return array;
}

void WriteArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

int Counter(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;
}




int[] myArray = AddArray();
WriteArray(myArray);
System.Console.WriteLine($"Количество элементов больше ноля равно: {Counter(myArray)}");