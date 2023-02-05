// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// Например:
// [345, 897, 568, 234] -> 2


Console.WriteLine("Введите число элементов массива: ");
int q = Convert.ToInt32(Console.ReadLine());

int[] coll = new int[q];

int length = coll.Length;
int index = 0;
while (index < length)
{
    coll[index] = new Random().Next(99, 1000);
      index++;
}

Console.WriteLine("Массив:");

Console.Write('[' + string.Join(", ", coll) + ']');

Console.WriteLine();

int count = 0;
index = 0;
while (index < length)
{
    if (coll[index] % 2==0)
    {
        count++;
        index++;
    }
    else
    {
        index++;
    };
};
Console.WriteLine();
Console.WriteLine("Количество четных чисел в массиве  равняется "+ count);
Console.WriteLine();