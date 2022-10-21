// Задайте массив вещественных чисел. Найдите разницу между максимальным 
// и минимальным элементов массива.
// [3 7 22 2 78] -> 76
   
double[] array = GetArray(4);
Console.WriteLine($"Массив: {String.Join(", ", array)}");

double minVaue = array[0], maxVaue = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (minVaue > array[i])
    {
        minVaue = array[i];
    }

    if (maxVaue < array[i])
    {
        maxVaue = array[i];
    }
}

Console.WriteLine($"Минимальное число: {minVaue}");
Console.WriteLine($"Максимальное число: {maxVaue}");
Console.WriteLine($"Разница между минимальным и максимальным числом: {maxVaue - minVaue}");

double[] GetArray(int size)
{
    double[] res = new double[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().NextDouble() * 100;
    }

    return res;
}