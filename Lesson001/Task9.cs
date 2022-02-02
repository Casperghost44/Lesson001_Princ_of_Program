using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson001
{
    public static class Task9
    {
        public static void Run()
        {
            string input = Input();

            string output = Count_letters(input);

            Output(output);
        }

        private static string Count_letters(string input)
        {
            string result = "";

            int[] zeros = new int[65536];

            for (int index = 0; index < input.Length; ++index)
            {
                zeros[(int)input[index]] += 1; 
            }
            for (int Index_zeros = 0; Index_zeros < zeros.Length; ++Index_zeros)
            {
                if (zeros[Index_zeros] > 0)
                {
                    result = result + (char)Index_zeros + ":" + " " + zeros[Index_zeros] + "\n";
                }
            }



            return result;
        }

        private static string Input()
        {
            Console.Write("Please enter a text: ");
            return Console.ReadLine();
        }

        private static void Output(string output)
        {
            Console.Write(":");
            Console.WriteLine(output);
        }

    }
}
