using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Arrey_Bidimencional_4.Clases
{
    internal class Ejercicios
    {              
        public void Ejercicio_4()
        {
            // a) Declarar y crear t
            int[,] t = new int[2, 3];

            // b) Número de filas
            int numRows = t.GetLength(0);

            // c) Número de columnas
            int numCols = t.GetLength(1);

            // d) Número total de elementos
            int totalElements = numRows * numCols;

            // e) Acceso a la fila 1 de t
            int[] fila1 = { t[1, 0], t[1, 1], t[1, 2] };

            // f) Acceso a la columna 2 de t
            int[] columna2 = { t[0, 2], t[1, 2] };

            // g) Asignación de cero a t[0,1]
            t[0, 1] = 0;

            // h) Inicialización de cada elemento de t a cero sin bucles
            t[0, 0] = 0;
            t[0, 1] = 0;
            t[0, 2] = 0;
            t[1, 0] = 0;
            t[1, 1] = 0;
            t[1, 2] = 0;

            // i) Inicialización de cada elemento de t a cero con bucles for anidados
            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j < numCols; j++)
                {
                    t[i, j] = 0;
                }
            }

            // j) Ingreso de valores por el usuario con bucles for anidados
            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j < numCols; j++)
                {
                    Console.Write($"Ingrese el valor para t[{i},{j}]: ");
                    t[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            // k) Encontrar el valor más pequeño en t
            int min = t[0, 0];
            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j < numCols; j++)
                {
                    if (t[i, j] < min)
                    {
                        min = t[i, j];
                    }
                }
            }
            Console.WriteLine($"El valor más pequeño en t es: {min}");



            // l) Mostrar los elementos de la primera fila de t
            Console.WriteLine($"Elementos de la primera fila de t: {t[0, 0]}, {t[0, 1]}, {t[0, 2]}");



            // m) Totalizar los elementos de la tercera columna de t
            int totalColumna3 = t[0, 2] + t[1, 2];
            Console.WriteLine($"La suma de la tercera columna es: {totalColumna3}");



            // n) Imprimir contenido de t en formato tabular
            Console.WriteLine("Índices de columna: 0  1  2");
            for (int i = 0; i < numRows; i++)
            {
                Console.Write($"Índice de fila {i}: ");
                for (int j = 0; j < numCols; j++)
                {
                    Console.Write($"{t[i, j]}  ");
                }
                Console.WriteLine();
            }

        }  
    }
}
