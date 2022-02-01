using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson001
{
    public static class Task6
    {
        public static void Run()
        {
            string input = Input();
            

            string output = Parse_link(input);

            Output(output);
        }

        private static string Parse_link(string input)
        {
            input = input + " ";
            int index_protocol = input.IndexOf(":");
            string protocol = input.Substring(0, index_protocol);
            int index_server = input.IndexOf("/", index_protocol + 3);
            int index_server_start = input.IndexOf("/", index_protocol + 2);
            string server = input.Substring(index_server_start + 1, index_server - index_server_start - 1);
            int index_resourse = input.IndexOf(" ");
            string resourse = input.Substring(index_server, index_resourse - index_server);
            return protocol + " " + server + " " + resourse;

        }




            
        

        private static string Input()
        {
            return "http://www.cnn.com/video";
        }

        private static void Output(string output)
        {
            char[] separetors = new char[] { ' ' };
            string[] list_of_elm = output.Split(separetors);
            Console.WriteLine("[protocol]=\"{0}\"", list_of_elm[0]);
            Console.WriteLine("[server]=\"{0}\"", list_of_elm[1]);
            Console.WriteLine("[resource]=\"{0}\"", list_of_elm[2]);
        }
    }
}
