// Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве.
// Например:
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да


// Формирование массива

Console.WriteLine("Введите число элементов массива: ");
int q = Convert.ToInt32(Console.ReadLine());

int[] coll = new int[q]; // Формирование массива

int length = coll.Length; //Определение длины массива
int index = 0;
while (index < length)
{
    coll[index] = new Random().Next(0, 100);
    index++;
}

Console.WriteLine("Массив:");

Console.Write('[' + string.Join(", ", coll) + ']'); // Вывод массива на Консоль

Console.WriteLine();

// Сравнение числа с элементами массива

Console.WriteLine("Задайте число: ");
int a = Convert.ToInt32(Console.ReadLine());

index = 0;
while (index < length)
{
    if (a == coll[index])
    {

        index = length+1; //length+1 - число за пределами массива, которое > length
    }
    else
    {
        index++;
    };
};

// Вывод информации
if (index == length+1)
{
    Console.WriteLine("Число " + a + " есть в массиве");
}
else
{
    Console.WriteLine("Число " + a + " отсутствует в массиве");
}