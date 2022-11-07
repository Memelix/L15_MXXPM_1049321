using System;

namespace L1_MXPM_1049321
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarar la matriz
            int[,] numeros = new int[40, 50];
            int suma = 0;

            //Numeros randoms de la tabla llena
            Random r = new Random();

            //Matriz vertical
            for (int i = 0; i < 40; i++)
            {
                for (int j = 0; j < 50; j++)
                {
                    numeros[i, j] = r.Next(-10, 50);
                }
            }
            for (int i = 0; i < 40; i++)
            {
                for (int j = 0; j < 50; j++)
                {
                    Console.Write("    " + numeros[i, j]);
                    //Suma de los valores
                    suma += numeros[i, j];
                }
            }
            Console.WriteLine("  ");
            Console.WriteLine("La suma total es: " + suma);
        }
    }
}
 


