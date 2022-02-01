using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson001
{
    public static class Task8
    {
        public static void Run()
        {
            string input = Input();

            string output = SortString(input);

            Output(output);
        }

        private static string SortString(string input)
        {
            var result = "";

            char[] separates = new char[] { ',', '.', ' ' };
            string[] list_of_word = input.Split(separates);
            Array.Sort(list_of_word);
            for (int index = 0; index < list_of_word.Length; ++index)
            {
                result += list_of_word[index] + " ";
                            
                
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
            Console.Write("Sort string is:");
            Console.WriteLine(output);
        }
    }
}
