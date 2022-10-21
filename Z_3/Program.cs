// Задайте массив вещественных чисел. Найдите разницу между максимальным 
// и минимальным элементов массива.
// [3 7 22 2 78] -> 76
   
double[] array = new double[] { 3, 7, 22, 2, 78 };
Console.Write(String.Join(",", array));
Console.Write($"-> {GetMaxValue(array) - GetMinValue(array)}");

double GetMinValue(double[] array)
{
    double result = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < result) result = array[i];
    }

    return result;
}

double GetMaxValue(double[] array)
{
    double result = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > result) result = array[i];
    }

    return result;
}
