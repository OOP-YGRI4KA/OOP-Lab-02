
using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть розмір матриці M: ");
            int m = Convert.ToInt32(Console.ReadLine());

            if (m <= 0)
            {
                Console.WriteLine("Розмір має бути більше 0.");
                return;
            }

            int[,] A = new int[m, m];

            InputMatrix(A, m);


            Console.WriteLine("\nПочаткова матриця:");
            PrintMatrix(A, m);

            int[] B = GetDiagonal(A, m);

            Console.WriteLine("\nОдновимірний масив:");

            for (int i = 0; i < m; i++)
            {
                Console.Write(B[i] + " ");
            }

            Console.ReadKey();
        }


        static void InputMatrix(int[,] A, int m)
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"A[{i},{j}] = ");
                    A[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        static void PrintMatrix(int[,] A, int m)
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(A[i, j] + "\t");
                }

                Console.WriteLine();
            }
        }

        static int[] GetDiagonal(int[,] A, int m)
        {
            int[] B = new int[m];

            for (int i = 0; i < m; i++)
            {
                B[i] = A[i, i];
            }

            return B;
        }
    }
}
