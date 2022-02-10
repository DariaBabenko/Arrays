using System;


namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Array = new int[5];
            Array[0] = 415;
            Array[1] = 45;
            Array[2] = 8924;
            Array[3] = 13;
            Array[4] = 526352;

            foreach (int El in Array)
            {
                Console.WriteLine(El);
            }
            Console.ReadKey();
        }
    }
}
