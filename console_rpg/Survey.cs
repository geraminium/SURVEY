using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;

namespace survey_game
{
    internal class Survey
    {
        static void Main(string[] args)
        {
            Faza1 faza1 = new Faza1();
            Tech.ServerStart();
            Console.WriteLine(" ░▒▓███████▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓███████▓▒░░▒▓█▓▒░░▒▓█▓▒░▒▓████████▓▒░▒▓█▓▒░░▒▓█▓▒░ \r\n░▒▓█▓▒░      ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░      ░▒▓█▓▒░░▒▓█▓▒░ \r\n░▒▓█▓▒░      ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░░▒▓█▓▒▒▓█▓▒░░▒▓█▓▒░      ░▒▓█▓▒░░▒▓█▓▒░ \r\n ░▒▓██████▓▒░░▒▓█▓▒░░▒▓█▓▒░▒▓███████▓▒░ ░▒▓█▓▒▒▓█▓▒░░▒▓██████▓▒░  ░▒▓██████▓▒░  \r\n       ░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░ ░▒▓█▓▓█▓▒░ ░▒▓█▓▒░         ░▒▓█▓▒░     \r\n       ░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░ ░▒▓█▓▓█▓▒░ ░▒▓█▓▒░         ░▒▓█▓▒░     \r\n░▒▓███████▓▒░ ░▒▓██████▓▒░░▒▓█▓▒░░▒▓█▓▒░  ░▒▓██▓▒░  ░▒▓████████▓▒░  ░▒▓█▓▒░     \r\nPress [Enter] to continue...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
            Console.Clear();
            char[] loadingChar = {'|', '/', '-', '\\'};
            for (int i = 0; i < 6; i++)
            {
                foreach (char c in loadingChar)
                {
                    Console.Clear() ;
                    Console.Write("\t" + c);
                    Task.Delay(100).Wait();
                }
            }
            faza1.Start();
        }
    }
}

