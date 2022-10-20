//Задайте массив заполненный случайными положительными
//трёхзначными числами. Напишите программу, которая покажет 
//количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int[] array = GetArray(4, 100, 999);
int CountEvenNumbers = GetCountEvenNumbers(array);
Console.Write(String.Join(" ", array));
Console.Write($" -> {CountEvenNumbers}");

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
int GetCountEvenNumbers(int[] arr)
{
    int CountEvenNumbers = 0;
    foreach (int el in arr)
    {
        if (el % 2 == 0) CountEvenNumbers += 1;
    }
    return CountEvenNumbers;
}
