internal class Program
{
    private static void Main(string[] args)
    {
        int fila = 3;
        int columna = 5;
        int i = 0, j = 0;
        int[,] matriz1 = new int[fila, columna];

        for (i = 0; i < fila; i++)
        {

            for (j = 0; j < columna; j++)
            {

                Console.Write("Ingrese el numero que quiere guardar en la fila " +
                i + ", Columna " + j + ": ");
                matriz1[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine();
        for (i = 0
            ; i < fila; i++)
        {

            for (j = 0; j < columna; j++)
            {

                Console.WriteLine("Fila: " + i + ", Columna: " + j + " = " + matriz1[i, j]);
            }   }

        Console.ReadKey();
    }
}