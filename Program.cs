Console.WriteLine("Введи количество символов в массиве: ");
int symbolsArray = Convert.ToInt32(Console.ReadLine());
string[] quantitySymbols = new string[symbolsArray];

InputSymbolsArray(quantitySymbols);

InputArray(quantitySymbols);

string[] lengthLessThanThree = LengthLessThanThree(quantitySymbols);

InputArray(lengthLessThanThree);

string[] InputSymbolsArray(string[] arr)
{
    int index = 1;
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"Введи в {index + i}м индексе  массива символы: ");
        arr[i] = Console.ReadLine();
    }
    return arr;
}

void InputArray(string[] inputArray)
{
    Console.Write("[");
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (i < inputArray.Length - 1) Console.Write($"\"{inputArray[i]}\", ");
        else Console.Write($"\"{inputArray[i]}\"");
    }
    Console.WriteLine("]");
}

string[] LengthLessThanThree(string[] arr)
{
    int count1 = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length < 4)
        {
            count1++;
        }
    }
    string[] lengthLessThanThree = new string[count1];
    int count2 = 0;
    for (int j = 0; j < arr.Length; j++)
    {
        if (arr[j].Length < 4)
        {
            lengthLessThanThree[count2] = arr[j];
            count2++;
        }
    }
    return lengthLessThanThree;
}