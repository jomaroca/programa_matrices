using System;

namespace Ejercicio_Matrices
{
    class Program
    {
        static void Main(string[] args)
        {
            string linea;

            Console.WriteLine("Cuantas filas quieres que tenga la primera matriz:");
            linea = Console.ReadLine();
            int fila1 = int.Parse(linea);
            Console.WriteLine("Cuantas columanas quieres que tenga la primera matriz");
            linea = Console.ReadLine();
            int colu1 = int.Parse(linea);

            //array matriz1
            int[,] matriz1 = new int[fila1, colu1];

            //leer datos y guardarlos en la matriz1
            for (int f = 0; f < matriz1.GetLength(0); f++)
            {
                for (int c = 0; c < matriz1.GetLength(1); c++)
                {
                    Console.Write("Introduce los valores de la primera matriz:");
                    linea = Console.ReadLine();
                    //leemos convertimos y asignamos
                    matriz1[f, c] = int.Parse(linea);
                }

            }

            //pedimos al usuario los datos de la segunda matriz
            Console.WriteLine("Cuantas filas quieres que tenga la segunda matriz:");
            linea = Console.ReadLine();
            int fila2 = int.Parse(linea);
            Console.WriteLine("Cuantas columanas quieres que tenga la segunda matriz");
            linea = Console.ReadLine();
            int colu2 = int.Parse(linea);

            //array matriz2
            int[,] matriz2 = new int[fila2, colu2];

            //leer datos y guardarlos en la matriz2
            for (int f = 0; f < matriz2.GetLength(0); f++)
            {
                for (int c = 0; c < matriz2.GetLength(1); c++)
                {
                    Console.Write("Introduce los valores de la segunda matriz:");
                    linea = Console.ReadLine();
                    //leemos convertimos y asignamos
                    matriz2[f, c] = int.Parse(linea);
                }

            }

            //imprimir en conosola la primera matriz
            Console.WriteLine("La Matriz1 tiene estos valores:");
            for (int f = 0; f < matriz1.GetLength(0); f++)
            {
                for (int c = 0; c < matriz1.GetLength(1); c++)
                {

                    Console.Write(matriz1[f, c]);
                }
                Console.WriteLine();
            }

            //imprimir en conosola la segunda matriz
            Console.WriteLine("La Matriz2 tiene estos valores:");
            for (int f = 0; f < matriz2.GetLength(0); f++)
            {
                for (int c = 0; c < matriz2.GetLength(1); c++)
                {
                    Console.Write(matriz2[f, c]);
                }
                Console.WriteLine();
            }

            // comparar tamaño de la matriz 1 y la matriz 2

            bool iguales = true;//Generar un booleano para posteriormente comparar los valores de las matrices que son de igual tamaño

            if (fila1 == fila2 && colu1 == colu2)
            {
                Console.WriteLine("Las matrices si pueden ser comparadas");
                //recorrer matrices y las comparar valores
                for (int j = 0; j < fila1; j++)
                {
                    for (int i = 0; i < colu1; i++)
                    {
                        if (matriz1[j, i] != matriz2[j, i])
                        {
                            Console.WriteLine("La matriz 1 tiene en {0} {1}: {2} y en matriz 2 {0} {1}: {3}", j, i, matriz1[j, i], matriz2[j, i]);
                            iguales = false;
                            break;
                        }

                    }

                }
                Console.WriteLine();
                if (iguales)
                {
                    Console.WriteLine("Las matrices son iguales");
                }
                else
                {
                    Console.WriteLine("Las matrices no son iguales");
                }

            }
            else
            {
                Console.WriteLine("Las matrices no pueden ser comparadas");
            }
        }
    }
}
