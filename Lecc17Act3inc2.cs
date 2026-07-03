using System;

class Program
{
    static void Main(string[] args)
    {
        int fila, columna, x, y, mayor;
        int[,] tabla = new int[4, 4];

        // Llenar la matriz
        for (fila = 0; fila < 4; fila++)
        {
            for (columna = 0; columna < 4; columna++)
            {
                Console.Write("Ingrese un número: ");
                tabla[fila, columna] = int.Parse(Console.ReadLine());
            }
        }

        // Inicializar el mayor
        mayor = tabla[0, 0];
        x = 0;
        y = 0;

        // Buscar el número mayor
        for (fila = 0; fila < 4; fila++)
        {
            for (columna = 0; columna < 4; columna++)
            {
                if (tabla[fila, columna] > mayor)
                {
                    mayor = tabla[fila, columna];
                    x = fila;
                    y = columna;
                }
            }
        }

        // Mostrar resultados
        Console.WriteLine("El número mayor es: " + mayor);
        Console.WriteLine("Está en la fila " + (x + 1));
        Console.WriteLine("Y en la columna " + (y + 1));

        Console.ReadKey();
    }
}