using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace survey_game
{
    internal class Phase1
    {
        List<string> questions = new List<string> {
            "Did you have a good day?",
            "Do you have many responsibilities?",
            "Do you have any pets?",
            "Have you ever commited a crime?",
            "Where is the body?"
        };

        public void Start()
        {
            Console.Clear();
            for (int i = 0; i < (questions.Count - 1); i++)
            {
                Task.Delay(2000).Wait();
                Console.Write("\n");
                foreach (char j in questions[i])
                {
                    Console.Write(j);
                    Task.Delay(25).Wait();
                }
                Console.Write(" [Y/N]\n");
                var check = Tech.KeyCheckResponse(Console.ReadKey().Key);
                if (!check)
                {
                    i--;
                    Task.Delay(3000).Wait();
                }
                Console.Clear();
            }
            Task.Delay(2000).Wait();

            Console.WriteLine(questions.Last());
            Task.Delay(2500).Wait();
            Process.Start(@"C:\WINDOWS\system32\rundll32.exe", "user32.dll,LockWorkStation");
            Task.Delay(100);
        }
    }
}