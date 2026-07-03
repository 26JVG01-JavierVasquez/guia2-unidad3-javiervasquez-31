using System;

class Program
{
    static void Main(string[] args)
    {
        int numeroFila, numeroColumna;
        int[,] matrizColumnas = new int[4, 4];

        // Llenar la matriz
        for (numeroFila = 0; numeroFila < 4; numeroFila++)
        {
            for (numeroColumna = 0; numeroColumna < 4; numeroColumna++)
            {
                matrizColumnas[numeroFila, numeroColumna] = numeroColumna + 1;
            }
        }

        Console.WriteLine("Matriz de Columnas");

        // Mostrar la matriz
        for (numeroFila = 0; numeroFila < 4; numeroFila++)
        {
            for (numeroColumna = 0; numeroColumna < 4; numeroColumna++)
            {
                Console.Write(matrizColumnas[numeroFila, numeroColumna] + " ");
            }
            Console.WriteLine();
        }

        Console.ReadKey();
    }
}