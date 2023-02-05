// Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов.В своём решении сделайте для 123.
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

Console.WriteLine("Введите число элементов массива: ");
int q = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Задайте наибольшее число массива: ");
int mmax = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Задайте число max отрезка массива: ");
int max = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Задайте число min отрезка массива: ");
int min = Convert.ToInt32(Console.ReadLine());


int[] coll = new int[q];


int length = coll.Length;
int index = 0;
while (index < length)
{
    coll[index] = new Random().Next(1, mmax);
    // Console.Write(coll[index] + " ");
    index++;
}

Console.WriteLine("Массив:");

Console.Write('[' + string.Join(", ", coll) + ']');

Console.WriteLine();

int count = 0;
index = 0;
while (index < length)
{
    if (coll[index] > min & coll[index] < max)
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
Console.WriteLine("Количество чисел в массиве между "+min+" и "+max+" равняется "+ count);
Console.WriteLine();