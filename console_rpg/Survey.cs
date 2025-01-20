using console_rpg;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Input;

namespace survey_game
{
    internal class Survey
    {
        static void Main(string[] args)
        {
            Phase1 phase1 = new Phase1();
            Phase2 phase2 = new Phase2();
            Phase3 phase3 = new Phase3();
            Phase4 phase4 = new Phase4();

            Console.Title = "SURVEY";
            Console.ForegroundColor = ConsoleColor.White;
            Console.WindowWidth = 150;
            Console.WindowHeight = 50;

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

            //phase1.Start();
            //phase2.Start();
            //phase3.Start();
            //phase4.Start();
            Credits.Roll();
        }
    }
}