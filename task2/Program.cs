// See https://aka.ms/new-console-template for more information
// Задача 2: Задача 1: Задайте значения M и N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от M до N.
//Использовать рекурсию, не использовать циклы.

//M = 8 
//N = 2-> "8, 7, 6, 5, 4, 3, 2"

Console.Clear();
Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
NaturalToLow(m, n);


void NaturalToLow(int m, int n)
{
    if (n > m)
    {
        return;
    }
    else
    {
        NaturalToLow(m, n + 1);
        Console.Write(n + " ");
    }
}