// Определить, присутсвует ли в заданном массиве, некоторое число
int[] arr = { 1, 56, 78, 9, 44, -9 };
for (int i = 0; i < arr.Length; i++) Console.Write($"{arr[i]} ");
Console.WriteLine();
Console.WriteLine("Введите число для поиска в массиве: ");
int num = int.Parse(Console.ReadLine());
int check = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] == num)
    {
        Console.WriteLine($"Заданное число {num} найдено в массиве ");
        check = 1;
        break;
    }
}
if (check == 0) Console.WriteLine($"Заданное число {num} не найдено в массиве ");

// Второй вариант
//int[] arr = { 1, 56, 78, 9, 44, -9 };
//int number = 56;
//string result = "";
//foreach (int var in arr)
//{
//    if (var == number)
//    {
//        result = "Есть!";
//        break;
//    }
//    else
//    {
//        result = "Нет!";
//    }
//}
//Console.WriteLine(result);