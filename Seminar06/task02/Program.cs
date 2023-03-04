int[] AddArray()
{
    int[] array = new int[3];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = ReadInt($"Введите значение {i + 1}-й стороны");
    }
    return array;
}

void WriteArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

bool TriangleCach(int[] array)
{
    bool proof = true;
    if (array[0] >= (array[1] + array[2]) || array[1] >= (array[0] + array[2]) || array[2] >= (array[1] + array[0]))
        proof = false;
    return proof;
    
}

var triangle = AddArray();
WriteArray(triangle);
System.Console.WriteLine($"Можно ли создать треугольник из указанных сторон? {TriangleCach(triangle)}");

