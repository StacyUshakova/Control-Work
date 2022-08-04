// Написать программу, которая из имеющегося масссива строк формирует массив строк, длина которых меньше либо равна 3 символа.

int NewArrayElements(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
            count++;
    }
    return count;
}

string[] NewArray(string[] array)
{
    int j = 0;
    string[] newarray = new string[NewArrayElements(array)];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            newarray[j] = array[i];
            j++;
        }
    }
    return newarray;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

string[] array = new string[4] {"hello", "2", "world", ":-)"};
string[] newarray = NewArray(array);
PrintArray(newarray);