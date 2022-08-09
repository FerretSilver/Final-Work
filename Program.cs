
string[] myArray;
Console.WriteLine("Введите массив строк через пробел:");
string stroka = Console.ReadLine();
myArray = stroka.Split(' ');


void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}


void Selection(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        string element = array[i];
        if (element.Length <= 3)
        {
            array[i] = element;
    }
        else array[i] = string.Empty;
    }
}

Selection(myArray);
Console.Write("Итоговый массив: ");
PrintArray(myArray);
