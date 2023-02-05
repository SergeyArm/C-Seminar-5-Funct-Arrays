// Напишите программу замены элементов массива:
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// Например:
// [-4, -8, 8, 2] -> [4, 8, -8, -2]



Console.WriteLine("Введите число элементов массива: ");
int q = Convert.ToInt32(Console.ReadLine());

int[] coll = new int[q]; // Формирование массива

int length = coll.Length; //Определение длины массива
int index = 0;
while (index < length)
{
    coll[index] = new Random().Next(-100, 100);
    index++;
}

Console.WriteLine("Массив:");

Console.Write('[' + string.Join(", ", coll) + ']'); // Вывод массива на Консоль

index=0;
while(index<length)
{
coll[index]= -coll[index];
index++;
};
Console.Write(" -> "+'[' + string.Join(", ", coll) + ']'); // Вывод массива на Консоль