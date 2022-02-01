using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson001
{
    public static class Task1
    {
        public static void Run()
        {
            string input = Input();

            string output = ReverseString(input);

            Output(output);
        }

        private static string ReverseString(string input)
        {
            var result = "";

            for (int i = input.Length - 1; i >= 0; i--)
            {
                result += input[i];
            }

            return result;
        }

        private static string Input()
        {
            Console.Write("Please enter a string: ");
            return Console.ReadLine();
        }

        private static void Output(string output)
        {
            Console.Write("Reverse version of that string is: ");
            Console.WriteLine(output);
        }
    }
}
