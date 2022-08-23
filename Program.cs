
Console.WriteLine("Введите размер массива:");
int n = Convert.ToInt32(Console.ReadLine());
string[] firstArray = new string[n];
string[] finalArray = new string[n];
FillArray(firstArray);
Selection(firstArray, finalArray);
PrintArray("Начальный массив: ", firstArray);
PrintArray("Итоговый массив: ", finalArray);


void FillArray(string[] array)
{
    for (int i = 0; i < n; i++)
    {
        Console.Write($"Введите символы эелемента №{i + 1}:  ");
        array[i] = Console.ReadLine();
    }

    Console.WriteLine();
}

void Selection(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if(array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}
void PrintArray (string text, string[] array)
{
    Console.WriteLine();
    Console.WriteLine($"{text}[{string.Join(", ", array)}]\n");
}
