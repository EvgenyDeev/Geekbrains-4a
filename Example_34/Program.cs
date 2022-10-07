/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2 */


Console.Clear();
Console.WriteLine("Введите колличество элементов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
int count = 0;

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(100, 1000);
}
    
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] %2 ==0)
        count++;
    }

Console.WriteLine("[" + string.Join(",", array) + "]");
 Console.WriteLine($"Количество чётных чисел в массиве : {count}");
