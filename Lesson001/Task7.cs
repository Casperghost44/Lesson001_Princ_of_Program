using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson001
{
    public static class Task7
    {
        public static void Run()
        {
            string input = Input();


            string output = OneElmString(input);

            Output(output);
        }

        private static string OneElmString(string input)
        {
            string result = "";
            input = input + " ";
            
            for (int index = 0; index < input.Length - 1; ++index)
            {
                if (input[index] == input[index + 1])
                {
                    continue;
                }
                else
                {
                    result += input[index];
                }
            }

           
          
            
            return result;

        }


        private static string Input()
        {
            return "aaaaabbbbbcdddeeeedssaa";
        }

        private static void Output(string output)
        {
            Console.WriteLine(output);
        }
    }
}
