using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net;
using System.Security.Cryptography.X509Certificates;



namespace survey_game
{
    internal class Tech
    {
        static HttpListener _httpListener = new HttpListener();

        public static string commandPrompt = $"{Environment.UserName}@{Environment.MachineName}:~$  ";
        public static List<ConsoleKey> answers = new List<ConsoleKey> { ConsoleKey.Y, ConsoleKey.N };

        public static List<string> dramaResponseY = new List<string>
        {
            "!!!!!!! WHY WOULDN'T YOU !!!!!!!",
            "!!!!!!! OF COURSE YOU DO !!!!!!!",
            "!!!!!!! NO WONDER YOU DO !!!!!!!",
            "!!!!!!! NOONE'S SURPRISED !!!!!!!"
        };

        public static List<string> dramaResponseN = new List<string>
        {
            "!!!!!!! YES YOU KNOW !!!!!!!",
            "!!!!!!! YOU F#CKING LIAR !!!!!!!",
            "!!!!!!! DON'T RUN FROM THE TRUTH !!!!!!!",
            "!!!!!!! DON'T LIE YOU COWARD !!!!!!!",

        };
        public static bool KeyCheckResponse(ConsoleKey key, bool drama = false)
        {
            if (answers.Contains(key))
            {
                if (drama)
                {
                    Random rnd = new Random();
                    int responseChoice = rnd.Next(0, 3);
                    switch (key)
                    {
                        case ConsoleKey.Y:
                            for (int i = 0; i < 100; i++)
                            {
                                Console.WriteLine(dramaResponseY[responseChoice]);
                                Task.Delay(10).Wait();
                            }
                            break;
                        case ConsoleKey.N:
                            for (int i = 0; i < 100; i++)
                            {
                                Console.WriteLine(dramaResponseN[responseChoice]);
                                Task.Delay(10).Wait();
                            }
                            break;
                    }
                }
                return true;
            }
            else
            {
                Console.WriteLine("\nPlease answer the questions in the form suggested by the administrator...");
                return false;
            }
        }

        private static void ResponseThread()
        {
            while (true)
            {
                HttpListenerContext context = _httpListener.GetContext();
                byte[] _responseArray = Encoding.UTF8.GetBytes("<html><head><title>Localhost server -- port 5000</title></head>" +
                "<body>Welcome to the <strong>Localhost server</strong> -- <em>port 5000!</em></body></html>");
                context.Response.OutputStream.Write(_responseArray, 0, _responseArray.Length);
                context.Response.KeepAlive = false;
                context.Response.Close();
            }
        }
        public static void Server()
        {
            _httpListener.Prefixes.Add("http://127.0.0.1/");
            _httpListener.Start();
            Thread _responseThread = new Thread(ResponseThread);
            _responseThread.Start();
        }
    }
}
