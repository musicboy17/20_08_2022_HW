// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет количество 
// чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.WriteLine("Введите размер массива size: ");
int size = Convert.ToInt32(Console.ReadLine()); 
int [] array = new int [size];

int index = 0;
int length = array.Length;

while (index < length)
{
    array[index] = new Random().Next(100, 1000);
    index++;
}


