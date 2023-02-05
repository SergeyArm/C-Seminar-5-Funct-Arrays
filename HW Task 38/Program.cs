// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// Например:
// [3.7; 7.2; 2.1; 7.8] -> 5.7


Console.WriteLine("Введите число элементов массива: ");
int q = Convert.ToInt32(Console.ReadLine());

// Генерация массива вещественных чисел

float[] coll = new float[q];

int index = 0;

while (index < q)
{
    float a = new Random().Next(-999, 1000);
    float b = new Random().Next(1, 100);
    coll[index] = a / b;
    index++;
}

Console.WriteLine("Массив:");

Console.Write('[' + string.Join("; ", coll) + ']');

Console.WriteLine();

// Нахождение максимального и минимального чисел в массиве

float max = coll[0];
float min = coll[0];

index = 0;
while (index < q)
{
    if (coll[index] >= max)
    {
        max = coll[index];
        index++;
    }
    else
    {
        if (coll[index] < min)
        {
            min = coll[index];
            index++;
        }
        else
        {
            index++;
        }
    };
};

// Вывод на консоль минимального, максимального чисел и их разности

Console.WriteLine();
Console.WriteLine("Минимальное число в массиве: " + min);
Console.WriteLine("Максимальное число в массиве: " + max);
Console.WriteLine("Разность между максимальным и минимальным числами массива равняется " + (max - min) + ".");
Console.WriteLine();