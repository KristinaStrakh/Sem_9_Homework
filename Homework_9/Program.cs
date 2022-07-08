/*Задача 64: Задайте значение N. 
Напишите программу, которая выведет все натуральные числа в промежутке от N до 1
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

int number = int.Parse(Console.ReadLine());
Console.WriteLine(NaturalNumber(number));

int NaturalNumber(int number)
{
    if (number == 1)
        return number;

    if (number > 1)

    {
        Console.Write($"{NaturalNumber(number - 1)}");
    }

    return number;

}

/*Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

/*int M = int.Parse(Console.ReadLine());
int N = int.Parse(Console.ReadLine());

Console.Write(SumNumbers(M, N));

int SumNumbers(int M, int N)
{
    
    if (M == N)
    {
        return M;
    }
    else
    {
        return N + SumNumbers(M,N - 1);
       
    }
}*/



/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n. 
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

/*int M = int.Parse(Console.ReadLine());
int N = int.Parse(Console.ReadLine());

int result = Akkerman(M,N);
Console.WriteLine(result);


int Akkerman(int M, int N)
{
    if(M == 0)
    {
        return N + 1;
    }
    if(M > 0 && N == 0)
    {
        return Akkerman(M - 1, 1); 
    }
    else if( M > 0 && N > 0)
    {
        return Akkerman(M - 1, Akkerman(M,N -1));
    }
    return Akkerman(M,N); 
}*/