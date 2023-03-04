int[] AddArray()
{
    System.Console.WriteLine("Введите энное количество чисел через пробел: ");
    int[] array = Array.ConvertAll(Console.ReadLine()!.Split(" "), int.Parse);
    return array;
}

int[] CopyArray(int[] arr)
{
    int[] newArr = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        newArr[i] = arr[i];
    }
    return newArr;
}

void WriteArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join("", array) + "]");
}

int[] myArray = AddArray();
WriteArray(myArray);
int[] newArray = CopyArray(myArray);
WriteArray(newArray);