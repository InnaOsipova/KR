
string [] ArrayFormation (string [] arr)
{
    string [] newarray = new string [arr.Length];
    int n = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            newarray[n] = arr[i];
            n++;
        }
    }
    return newarray;
}

void PrintArray (string [] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine(arr[i]+"  ");
    }
}

Console.Write("Какой длинны будет массив? : ");
int number = Convert.ToInt32(Console.ReadLine());
string [] array = new string [number];
for (int i = 0; i < number; i++)
{
   Console.Write($"ведите {i+1} элемент массива    ");
   array[i] = Console.ReadLine();
}

Console.WriteLine("Массив слов длиной меньше 3 символов :");
PrintArray(ArrayFormation(array));