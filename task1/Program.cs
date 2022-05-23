// написать программу замены элементов массива на противоположные
int[] array = { 1, 2, 3, 4, 5, 6, 7, 8 };
void change(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        array[i] = 0 - array[i];
    }
}
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int j = 0; j < count; j++)
    {
        Console.Write($"{array[j]}");
    }
}
change(array);
PrintArray(array);