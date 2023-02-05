// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// Например:
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Введите число элементов массива: ");
int q = Convert.ToInt32(Console.ReadLine());

int[] coll = new int[q];

int length = coll.Length;
int index = 0;
while (index < length)
{
    coll[index] = new Random().Next(-100, 100);
    index++;
}

Console.WriteLine("Массив:");

Console.Write('[' + string.Join(", ", coll) + ']');

Console.WriteLine();

int summ = 0;
index = 0;
while (index < length)
{
    if (index % 2 == 0)
    {
        index++;
    }
    else
    {
        summ = summ + coll[index];
        index++;
    };
};
Console.WriteLine();
Console.WriteLine("Сумма элементов, стоящих на нечетных позициях равняется " + summ + ".");
Console.WriteLine();