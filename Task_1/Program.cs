// Задача 34:
// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void Main()
{
    int[] array = FillArray(4);
    PrintArray(array);
    FindEvenNumber(array, out int evens);
    System.Console.WriteLine($"Количество четных чисел: {evens}");
}

Main();

int[] FillArray(int size)
{
    int[] tempArray = new int[size];
    Random rand = new Random();

    for (int i = 0; i < tempArray.Length; i++)
    {
        tempArray[i] = rand.Next(100, 1000);
    }
    return tempArray;
}

void PrintArray(int[] arrayForPrint)
{
    System.Console.WriteLine("[" + string.Join(", ", arrayForPrint) + "]");
}

void FindEvenNumber(int[] array, out int evens)
{
    evens = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            evens++;
        }
    }
}