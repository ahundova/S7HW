// See https://aka.ms/new-console-template for more information
/*Задача 3: Задайте произвольный массив. Выведете его элементы, 
начиная с конца. Использовать рекурсию, не использовать циклы.*/
Console.Clear();
void PrintArr(int[] array, int i = 0)
{
    if (i != array.Length)
    {
        PrintArr(array, i + 1);
        Console.Write($"{array[i]} ");
    }
}

var array = new int[] { 14, 31, 27, 12, 54 };
PrintArr(array);

