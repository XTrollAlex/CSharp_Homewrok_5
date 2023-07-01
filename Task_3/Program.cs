// Задача 38:
// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


void Main()
{
    double[] array = FillArray(5, 0, 100);
    PrintArray(array);
    FindMinMaxDelta(array, out double min, out double max, out double delta);
    System.Console.WriteLine($"Разница между максимальным элементом '{max}' и минимальным элементом '{min}' составляет: {delta}");
}

Main();

double[] FillArray(int size, int leftRange, int rightRange)
{
    double[] tempArray = new double[size];
    Random rand = new Random();

    for (int i = 0; i < tempArray.Length; i++)
    {
        tempArray[i] = Math.Round(rand.Next(leftRange, rightRange) + rand.NextDouble, 3);
    }

    return tempArray;
}

void PrintArray(double[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

void FindMinMaxDelta(double[] array, out double min, out double max, out double delta)
{
    min = array[0];
    max = array[0];
    
    for (int i = 1; i < array.Length; i++)
    {
        if (array [i] < min)
        {
            min = array [i];
        }
        else if (array [i] > max)
        {
            max = array [i];
        }
        i++;
    }
    delta = max - min;
}