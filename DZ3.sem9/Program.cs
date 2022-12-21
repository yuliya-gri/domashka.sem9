// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
Console.WriteLine("Напишите число N");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Напишите число M");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{N}  {M} -> {AkkRec(N, M)}");

int AkkRec( int N, int M)
{
    if (N == 0) return M + 1;
    if(N != 0 &&  M == 0) return AkkRec(N-1, 1);
    if(N > 0 && M > 0) return AkkRec(N -1, AkkRec(N, M - 1));
  return AkkRec(N, M);
}