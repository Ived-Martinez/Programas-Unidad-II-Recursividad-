/*Programa 5
invertir el orden de un numero entero positivo mediante llamadas recursivas */
using System;
class Program
{
    static long Invertir(long n, long resultado = 0)
    {
        if (n == 0)
            return resultado;
        return Invertir(n / 10, resultado * 10 + n % 10);
    }
    static void Main()
    {
        Console.Write("ingresa un numero positivo:");
        long n = long.Parse(Console.ReadLine());
        if (n < 0)
        {
            Console.WriteLine("El numero debe ser positivo.");
            return;
        }
        Console.WriteLine("Numero invertido:" + Invertir(n));
    }
}