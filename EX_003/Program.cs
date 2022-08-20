// Задача 38: Задайте массив вещественных чисел. Найдите разницу 
// между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

Console.WriteLine("Введите размер массива size: ");
int size = Convert.ToInt32(Console.ReadLine()); 
double [] array = new double [size];

int index = 0;
int length = array.Length;

while (index < length)
{
    array[index] = new Random().Next(1, 100);
    index++;
}

Console.WriteLine($"[{String.Join("; ", array)}]");

double minElement = array[0];
double maxElement = array[0];

int count = array.Length;

for (int i = 0; i < count; i++)
{
    if (array[i] < minElement)
    minElement = array[i];
    if (array[i] > maxElement)
    maxElement = array[i];    
    
}

double diff = 0;
diff = maxElement - minElement;

Console.WriteLine($"Минимальный элемент - {minElement} ");

Console.WriteLine($"Максимальный элемент - {maxElement} ");

Console.WriteLine($"Разница между максимальным и минимальным элементами - {diff} ");

