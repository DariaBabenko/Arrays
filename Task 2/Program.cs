using System;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string [] Array = new string[5];
            Array[0] = "sun";
            Array[1] = "rain";
            Array[2] = "snow";
            Array[3] = "wind";
            Array[4] = "fog";


            for (int i = Array.Length - 1; i >=0; i--)

            {
                Console.WriteLine(Array[i]);
            }
            Console.ReadKey();
        }
    }
}
