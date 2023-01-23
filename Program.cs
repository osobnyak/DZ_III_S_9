// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


Console.WriteLine("ВВедите число N: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(); 

int Nat(int num)
{
    if (num == 1) // точка выхода
    {
        return 1;
    }
    Console.Write(num + " "); 
    return Nat(num-1);
}

int x = Nat(num);
Console.WriteLine(x); 