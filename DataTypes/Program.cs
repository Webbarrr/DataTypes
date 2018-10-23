using System;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Write a C# Sharp program that takes three letters as input and display them in reverse order.
            Ex1(Ask("Give me at least 3 letters: "));



            Console.ReadLine();
        }
        static string Ask(string question)
        {
            Console.Write(question);
            return Console.ReadLine();
        }
        static void Ex1(string letters)
        {
            char[] chars = letters.ToCharArray();
            Array.Reverse(chars);
            Console.Write(string.Join(null, chars));
        }
    }

}
