/*Programa 2
Programa que determine el valor de una poseciòn entre (0 y 40) de la serie fibonacci*/
using System;
class program
{
    static long Fibonacci(int n)
    {
        if (n <= 1)
            return n;
        return Fibonacci(n - 1) + Fibonacci(n-2);
    }
    static void Main()
    {
        Console.Write("Ingrese la posición: ");
        int n = int.Parse(Console.ReadLine());

        if (n < 0 || n > 40)
        {
            Console.WriteLine("Ingrese un numero de 0 y 40.");
            return;
        }
        Console.WriteLine("Fibonacci:" + Fibonacci(n));
    }
}

