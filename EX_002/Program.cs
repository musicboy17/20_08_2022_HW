// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

Console.WriteLine("Введите размер массива size: ");
int size = Convert.ToInt32(Console.ReadLine()); 
int [] array = new int [size];

int index = 0;
int length = array.Length;

while (index < length)
{
    array[index] = new Random().Next(-100, 100);
    index++;
}
Console.WriteLine($"[{String.Join("; ", array)}]");