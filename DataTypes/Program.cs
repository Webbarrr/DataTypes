using System;
using System.Linq;
using System.Text;

namespace DataTypes
{
    class Program
    {
        static void Main()
        {
            // 1. Write a C# Sharp program that takes three letters as input and display them in reverse order.
            Ex1(Ask("Give me at least 3 letters: "));

            // 2. Write a C# Sharp program that takes a number and a width also a number, as input and then displays a triangle of that width, using that number.
            Console.WriteLine(Ex2(6, 6));

            // 3. Write a C# Sharp program that takes userid and password as input (type string). After 3 wrong attempts, user will be rejected.
            bool success = false;
            int attempts = 0;
            string username = null, password = null;

            while (!success)
            {
                username = Ask("Give me your username: ");
                password = Ask("Give me your password: ");

                if (!Ex3(username, password))
                {
                    attempts++;
                    Console.WriteLine("Wrong combination.");
                }
                else
                {
                    success = true;
                    Console.WriteLine("Welcome {0}!", username);
                    break;
                }

                if (attempts == 3)
                {
                    Console.WriteLine("You failed.");
                    break;
                }
            }

            // 4. Write a C# Sharp program that takes two numbers as input and perform an operation (+,-,*,x,/) on them and displays the result of that operation.
            Console.WriteLine(Ex4(20, 12, "-"));

            // 5. Write a C# Sharp program that takes the radius of a circle as input and calculate the perimeter and area of the circle.
            Console.WriteLine(Ex5(12));

            Console.ReadLine();
        }
        private static string Ask(string question)
        {
            Console.Write(question);
            return Console.ReadLine();
        }
        private static void Ex1(string letters)
        {
            char[] chars = letters.ToCharArray();
            Array.Reverse(chars);
            Console.Write(string.Join(null, chars));
        }
        private static string Ex2(int num, int width)
        {
            StringBuilder retVal = new StringBuilder();
            for (int i = width; i > 0; i--)
            {
                retVal.Append(string.Concat(Enumerable.Repeat(num.ToString(), i)));
                retVal.AppendLine();
            }
            return retVal.ToString();
        }
        private static bool Ex3(string username, string password)
        {
            string _username = "CoolGuy22", _password = "uNhAcKaBl3";
            return username == _username && password == _password;
        }
        private static int Ex4(int x, int y, string op)
        {
            switch (op)
            {
                case "+":
                    return x + y;
                case "-":
                    return x - y;
                case "*":
                    return x * y;
                case "/":
                    return x / y;
                default:
                    return 0;
            }
        }
        private static double Ex5(int radius)
        {
            return 2 * 3.14 * radius;
        }
    }

}