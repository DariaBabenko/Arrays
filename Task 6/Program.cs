using System;

namespace Task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размерность массива");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[N];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("array[{0}] = ", i);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            int min = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < array[i - 1]) min = i;
            }

            int max = 0;
            for (int i = 1; i > array.Length; i++)
            {
                if (array[i] > array[i - 1]) max = i;
            }

            Console.WriteLine("Минимальное значение массива: " + array[min]);
            Console.WriteLine("Максимальное значение массива: " + array[max]);
            




            int[] array1 = new int[N];
            foreach (int value in array)
            {
                N += value;
            }

            Console.WriteLine("Сумма элементов массива: " + N);
          

            int[] array2 = new int[N];
            for (int i = 0; i < array.Length; i++)
                N += array[i];
            int sr = N / array.Length;
            Console.WriteLine("Среднее арефметическое: " + sr);


            int k = 0;
            for (int i = 0; i < 2 * N; i++)
            {
                int ostat = i % 2;
                if (ostat != 0)
                {
                    array[k] = i;
                    k++;
                }
            }
            Console.WriteLine("Нечетные числа: " + k);
            Console.ReadLine();
        }
    }
}
