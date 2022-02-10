using System;

namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            NameReturn(char Carolina);
        }

        static char NameReturn(char Carolina)
        {
            char[] name = "Carolina".ToCharArray();
            Array.Reverse(name);
            Console.WriteLine(name);

            return Array.Reverse(name); ;
        }
        
    }
}
