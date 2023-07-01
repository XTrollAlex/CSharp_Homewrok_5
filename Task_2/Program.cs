// Задача 36:
// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void Main()
{
    int[] array = FillArray(4, -15, 15);
    PrintArray(array);
    SumOddPosition(array, out int sum);
    System.Console.WriteLine($"Сумма элементов на нечетных позициях: {sum}");
}

Main();

int[] FillArray(int size, int leftRange, int rightRange)
{
    int[] tempArray = new int[size];
    Random rand = new Random();

    for (int i = 0; i < tempArray.Length; i++)
    {
        tempArray[i] = rand.Next(leftRange, rightRange + 1);
    }

    return tempArray;
}

void PrintArray(int[] arrayForPrint)
{
    System.Console.WriteLine("[" + string.Join(", ", arrayForPrint) + "]");
}

void SumOddPosition(int[] array, out int sum)
{
    sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 < 0 || i % 2 > 0)
        {
            sum += array [i];
        }
    }
}