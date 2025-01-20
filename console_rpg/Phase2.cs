using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using survey_game;
using System.Diagnostics;
using System.IO;

namespace survey_game
{
    internal class Phase2
    {
        List<string> questions = new List<string>()
        {
            "Did you have a good day?",
            "Do you have many responsibilities?",
            "Do you like ice cream?",
            "Are you comfortable in your own room?",
            "Do you feel safe?",
            "Do you know the person in this picture? [Y/N]"
        };

        public void Start()
        {
            Console.Clear();
            for (int i = 0; i < (questions.Count() - 1); i++)
            {
                Task.Delay(2000).Wait();
                Console.Write("\n");
                foreach (char j in questions[i])
                {
                    Console.Write(j);
                    Task.Delay(25).Wait();
                }
                Console.Write(" [Y/N]\n");
                var checkLocal = Tech.KeyCheckResponse(Console.ReadKey().Key);
                if (!checkLocal)
                {
                    i--;
                    Task.Delay(4500).Wait();
                }
                Console.Clear();
            }

            Process explorer = new Process();
            explorer.StartInfo.FileName = Tech.getDefaultBrowser();
            explorer.StartInfo.Arguments = Environment.CurrentDirectory + "\\victim_report_site\\phase2_person.html";
            explorer.Start();

            Console.WriteLine(questions.Last());
            for (int i = questions.Count; i <= (questions.Count()); i++)
            {
                var checkLast = Tech.KeyCheckResponse(Console.ReadKey().Key);
                if (!checkLast)
                {
                    i--;
                    Task.Delay(4500).Wait();
                }
                Console.Clear();
            }
            Console.Clear();
            Process.Start(@"C:\WINDOWS\system32\rundll32.exe", "user32.dll,LockWorkStation");
        }
    }
}