// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] array = {6,7,3,6,10};
int length = array.Length;
int index = 0;

while(index<=(length-1-index))
{
    if((index==(length-1-index)))
    {
Console.Write(" "+array[index]);
    }
    else
    {
Console.Write(" "+array[index] * array[length-1-index]);
    }
index++;
}