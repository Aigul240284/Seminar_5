// Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = GetArray(6, -9, 9);
Console.Write(String.Join(",", array));
int SumOddNumbers = GetSumOddNumbers(array);
Console.Write($" -> {SumOddNumbers}");


/////
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}
/////
int GetSumOddNumbers(int[] array)
{
    int SumOddNumbers = 0;
    for (int i = 1; i < array.Length; i++)

    {
        if (i % 2 != 0) SumOddNumbers = SumOddNumbers + array[i];
    }
    return SumOddNumbers;
}
