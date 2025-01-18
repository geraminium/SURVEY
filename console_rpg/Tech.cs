﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;



namespace survey_game
{
    internal class Tech
    {
        static HttpListener listener = new HttpListener();
        static HttpListenerContext context = listener.GetContext();
        protected static HttpListenerRequest request = context.Request;
        protected static HttpListenerResponse response = context.Response;

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

        public static void ServerStart()
        {
            listener.Prefixes.Add("http://127.0.0.1/");
            listener.Start();
        }
        public static void ServerUpdate(string bufferInput) { 
            byte[] buffer = Encoding.UTF8.GetBytes(bufferInput);
            response.ContentLength64 = buffer.Length;
            System.IO.Stream output = response.OutputStream;
            output.Write(buffer, 0, buffer.Length);
            output.Close();
        }
    }
}
