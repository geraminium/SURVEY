using survey_game;
using System;
using System.Collections.Generic;
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
                    Task.Delay(4500).Wait();
                }
                Console.Clear();
            }

            int counter = 0;

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
        }
    }
}
