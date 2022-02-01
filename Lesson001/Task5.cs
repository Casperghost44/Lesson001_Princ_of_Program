using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson001
{
    public static class Task5
    {
        public static void Run()
        {
            string input = Input();

            string forbidden_words = "Mincrosoft, C#, CLR";

            string output = StringWithoutForbiddenwords(input, forbidden_words);

            Output(output);
        }

        private static string StringWithoutForbiddenwords(string input, string forbidden_words)
        {
            
            string result = "";
            string first_change = input.Replace("Mincrosoft", "***********");
            result = first_change;
            result = result.Replace("C#", "**");
        
            result = result.Replace("CLR", "***");
           

            

           
            return result;
        }

        private static string Input()
        {
            return "Mincrosoft announced its next generation C# compiler today. It uses advanced parser and special optimizer for the Mincrosoft CLR.";
            
        }

        private static void Output(string output)
        {
            
            Console.WriteLine(output);
        }
    }
}
