using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using survey_game;

namespace console_rpg
{
    internal class Phase3
    {
        List<string> questions = new List<string>()
        {
            "Have you ever been abroad?",
            "Have you ever visited Italy?",
            "Do you like to swim?",
            "Do you swim at Lake Orta often?",
            "Do you know why am I asking this?"
        };

        public void Start()
        {
            Console.Clear();
            for (int i = 0; i < (questions.Count()); i++)
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
                    Task.Delay(4500).Wait();
                }
                else if (i == 3 && answer == ConsoleKey.N)
                {
                    Console.WriteLine("\nDon't lie to yourself...");
                    Task.Delay(1000).Wait();
                }
                Console.Clear();
            }
        }
    }
}