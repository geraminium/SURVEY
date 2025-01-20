using survey_game;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_rpg
{
    internal class Phase4
    {
        List<string> questions = new List<string>()
        {
            "Do you have any regrets?",
            "Is there something wrong with you?",
            "Was the motive good enough for you?",
            "Did she struggle a lot?",
            "Did you enjoy CHOKING HER YOU ANIMAL?",
            "DID YOU KNOW SHE HAD AMBITIONS?",
            "SHE TRIED TO SCREAM, DIDN'T SHE?",
            "AND YOU DIDN'T EVEN FLINCH, RIGHT?",
            "WHY DID YOU KILL HER!?!?"
        };
        public void Start()
        {
            Console.Clear();
            for (int i = 0; i < 4; i++)
            {
                Task.Delay(2000).Wait();
                Console.Write("\n");
                foreach (char j in questions[i])
                {
                    Console.Write(j);
                    Task.Delay(25).Wait();
                }
                Console.Write(" [Y/N]\n");

                ConsoleKey answer = Console.ReadKey().Key;
                var checkLocal = Tech.KeyCheckResponse(answer);
                if (!checkLocal)
                {
                    i--;
                    Task.Delay(3000).Wait();
                }
                Console.Clear();
            }


            int counter = 0;
            Task.Delay(2000).Wait();
            Console.WriteLine("\n");
            foreach (char i in questions[4])
            {
                if (counter < 14)
                {
                    counter++;
                    Console.Write(i);
                    Task.Delay(25).Wait();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write(i);
                    Task.Delay(25).Wait();
                }
            }
            Console.Write(" [Y/N]");
            ConsoleKey check = Console.ReadKey().Key;
            Console.Clear();

            for (int i = 5; i < (questions.Count() - 1); i++)
            {
                Task.Delay(2000).Wait();
                Console.WriteLine("\n");
                if (i > 5)
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.ForegroundColor = ConsoleColor.Black;
                    foreach (char j in questions[i])
                    {
                        Console.Write(j);
                        Task.Delay(40 + i).Wait();
                    }
                }
                else
                {
                    foreach (char j in questions[i])
                    {
                        Console.Write(j);
                        Task.Delay(25).Wait();
                    }
                }
                Console.Write(" [Y/N]");
                ConsoleKey check2internal = Console.ReadKey().Key;
                Console.Clear();
            }
            foreach (char i in questions.Last())
            {
                Console.Write(i);
                Task.Delay(10).Wait();
            }
            Task.Delay(1000).Wait();
            for (int i = 0; i < 100; i++)
            {
                Console.Write("░▒▓█▓▒░░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░ \r\n░▒▓█▓▒░░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░ \r\n░▒▓█▓▒░░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░ \r\n░▒▓█▓▒░░▒▓█▓▒░░▒▓█▓▒░▒▓████████▓▒░░▒▓██████▓▒░  \r\n░▒▓█▓▒░░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░  ░▒▓█▓▒░     \r\n░▒▓█▓▒░░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░  ░▒▓█▓▒░     \r\n ░▒▓█████████████▓▒░░▒▓█▓▒░░▒▓█▓▒░  ░▒▓█▓▒░     \r\n\n");
                Task.Delay(250);
            }
            Process.Start(@"C:\WINDOWS\system32\rundll32.exe", "user32.dll,LockWorkStation");
        }
    }
}