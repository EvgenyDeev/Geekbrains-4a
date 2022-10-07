/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0 */

Console.Clear();

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(-100, 101);
}

int SumNumbers(int[] array)
{
    int Sum = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
        if(array[i] > 0 | array[i] < 0)
        Sum += array[i];
    }
    return Sum;
}

Console.WriteLine("Введите колличество элементов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine("[" + string.Join(",", array) + "]");
Console.WriteLine($"Сумма не четных элементов массива : {SumNumbers(array)}");