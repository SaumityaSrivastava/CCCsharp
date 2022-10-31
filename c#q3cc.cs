using System;

namespace RectangularArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] ar = new int[n, n];
            int m, l;
            ar = Program.GetArray(int n);

            for (m = 0; m < n; m++)
            {
                for (l = 0; l < n; l++)
                {
                    Console.Write(ar[m, l] + " ");
                }
                Console.WriteLine();
            }
        }
        public static int[,] GetArray(int a)
        {
            int[,] arr = new int[a, a];
            int i, j;
            for (i = 0; i < a; i++)
            {

                for (j = 0; j < a; j++)
                {
                    if (i == j)
                    {
                        arr[i, j] = 0;
                    }
                    else if (i < j)
                    {
                        arr[i, j] = 1;
                    }
                    else
                    {
                        arr[i, j] = -1;
                    }


                }
            }
            return arr;



        }
    }
}