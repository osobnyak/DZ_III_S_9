// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
// элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.WriteLine("ВВедите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ВВедите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N < M && N < 0) { N = N * -1; M = M * -1;} // защита от того, что второе число меньше первого
if (N < M) 
    {
        int N1 = N; 
        int M1 = M;
        N = M1;
        M = N1;   
    }

int sum = M;
Console.WriteLine();

int Nat(int N, int M)
{
    if (N == M) // точка выхода
    {
        return M;
    }
    Console.Write(N + " ");
    sum = sum + N;
    return Nat(N - 1, M);
    Console.Write(sum + " ");
    return sum;
}

int x = Nat(N, M);
Console.WriteLine(x);
Console.WriteLine(sum);