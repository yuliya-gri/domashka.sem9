// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.WriteLine("Напишите число M");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Напишите число N");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ($"Сумма элементов в промежутке от {M} до {N} равна {sumRec(M, N)}");

int sumRec( int M, int N)
{
    if(M == N) return N ;
    return N + sumRec(M, N - 1 );
}