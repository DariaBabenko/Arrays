using System;
namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] A = new string[4];
            string[] B = new string[4];

            for (int i = 0; i < A.Length; i++)
            {
                Console.WriteLine($"Введите элемент массива под индексом {i}: ");
                A [i] = Console.ReadLine();
            }
 
            for (int i = 0; i < 4; i++)
            {
                B [i] = A[4 - i - 1];
               Console.WriteLine(B [i]);
            }

            Console.ReadKey();
        }
    }
}
