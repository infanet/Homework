Console.WriteLine("Введи количество символов в массиве: ");
int symbolsArray = Convert.ToInt32(Console.ReadLine());
string[] quantitySymbols = new string[symbolsArray];

string[] inputSymbolsArray = InputSymbolsArray(quantitySymbols);

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