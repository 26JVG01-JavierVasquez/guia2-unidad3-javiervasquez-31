using System;

class Program
{
    static void Main(string[] args)
    {
        int fila, columna, num, suma;
        int[,] tabla = new int[4, 3];

        for (fila = 0; fila < 4; fila++)
        {
            suma = 0;

            for (columna = 0; columna < 3; columna++)
            {
                Console.Write("Ingrese un número: ");
                num = int.Parse(Console.ReadLine());

                tabla[fila, columna] = num;
                suma += num;
            }

            Console.WriteLine("La suma de la fila " + (fila + 1) + " es: " + suma);
        }

        Console.ReadKey();
    }
}