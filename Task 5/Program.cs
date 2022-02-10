using System;

namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int min = 0;    
            int max = 0;  

            int [] Month = new int [12];
            Month[0] = 1;
            Month[1] = 2;
            Month[2] = 3;
            Month[3] = 4;
            Month[4] = 5;
            Month[5] = 6;
            Month[6] = 7;
            Month[7] = 8;
            Month[8] = 9;
            Month[9] = 10;
            Month[10] = 11;
            Month[11] = 12;


            for (int i = 0; i < Month.Length; i++)
            {
                Console.WriteLine($"Введите прибыль фирмы за месяца  {i}");
                int profit = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Введите номер месяца с которого вы хотите получить отчёт");
            int month1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите номер месяца по который вы хотите получить отчёт");
            int month2 = int.Parse(Console.ReadLine());
            for (int i = month1;i < month2;i++)
            {
                if (i == month1)
                {
                    max = Month[i];
                    min = Month[i];
                }
                if (max < Month[i])
                {
                    max = Month[i];
                }
                if (min > Month[i])
                {
                    min = Month[i];
                }

                Console.WriteLine($"Максимальная прибыль заза выбранный период составляеm");
                Console.WriteLine($"Минимальная прибыль за выбранный период составляет");
            }

            Console.ReadKey();
               
        }
    }
}
