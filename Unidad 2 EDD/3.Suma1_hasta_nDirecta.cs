/*Programa 3
Calcula la suma de todos los numeros enteros desde 1 hasta el numero ingresado*/
using System;
class program
{
    static int Suma(int n)
    {
        if (n <= 0)
            return 0;
        return n + Suma(n-1);
    }
    static void Main ()
    {
        Console.Write("ingresa un numero:");
        int n = int.Parse(Console.ReadLine());

        if(n<0 ||  n >10000)
        {
            Console.WriteLine("Ingresa un numero entero 0 y 10000.");
            return;
        }

        Console.WriteLine("La suma es:" + Suma(n));
    }
}