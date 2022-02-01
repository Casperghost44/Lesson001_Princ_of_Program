using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson001
{
    class Task4
    {
        public static void Run()
        {
            string input = Input();
            string word = "submarine";

            string output = ExtractSentences(input, word);

            Output(output);
        }

        private static string ExtractSentences(string input, string word)
        {
            
            
            
            string sentence = "";
            int index = 0;
            string result = "";
            string corSentense = "";

            char[] separetors = new char[] { '.' };
            string[] sentenseArr = input.Split(separetors);
            for (int index_of_sent = 0; index_of_sent < sentenseArr.Length; ++index_of_sent)
            {
                sentence = sentenseArr[index_of_sent];
                index = sentence.IndexOf(word);
                if (index != -1)
                {
                    corSentense = sentence + ".";
                    result += corSentense;
                }
                else
                {
                    continue;
                }
                
            }
           

            

            return result;
        }

        private static string Input()
        {
            return "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        }

        private static void Output(string output)
        {
            Console.WriteLine(output);
        }
    }
}
