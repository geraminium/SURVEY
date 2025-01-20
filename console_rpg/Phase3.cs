using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace survey_game
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

                ConsoleKey answer = Console.ReadKey().Key;
                var checkLocal = Tech.KeyCheckResponse(answer);
                if (!checkLocal)
                {
                    i--;
                    Task.Delay(3000).Wait();
                }
                else if (i == 3 && answer == ConsoleKey.N)
                {
                    Console.WriteLine("\nDon't lie to yourself...");
                    Task.Delay(1000).Wait();
                }
                Console.Clear();
            }

            Task.Delay(2000).Wait();
            Console.WriteLine(questions.Last());
            for (int i = questions.Count - 1; i < (questions.Count()); i++)
            {
                Task.Delay(2000).Wait();
                Console.Write("\n");
                foreach (char j in questions[i])
                {
                    Console.Write(j);
                    Task.Delay(25).Wait();
                }
                Console.Write(" [Y/N]");

                var checkLast = Tech.KeyCheckResponse(Console.ReadKey().Key, true);
                if (!checkLast)
                {
                    i--;
                    Task.Delay(3000).Wait();
                }
                Console.Clear();
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("`YMM'   `MM' .g8\"\"8q. `7MMF'   `7MF'          db      `7MN.   `7MF'`7MMF'`7MMM.     ,MMF'      db      `7MMF'      \r\n  VMA   ,V .dP'    `YM. MM       M           ;MM:       MMN.    M    MM    MMMb    dPMM       ;MM:       MM        \r\n   VMA ,V  dM'      `MM MM       M          ,V^MM.      M YMb   M    MM    M YM   ,M MM      ,V^MM.      MM        \r\n    VMMP   MM        MM MM       M         ,M  `MM      M  `MN. M    MM    M  Mb  M' MM     ,M  `MM      MM        \r\n     MM    MM.      ,MP MM       M         AbmmmqMA     M   `MM.M    MM    M  YM.P'  MM     AbmmmqMA     MM      , \r\n     MM    `Mb.    ,dP' YM.     ,M        A'     VML    M     YMM    MM    M  `YM'   MM    A'     VML    MM     ,M \r\n   .JMML.    `\"bmmd\"'    `bmmmmd\"'      .AMA.   .AMMA..JML.    YM  .JMML..JML. `'  .JMML..AMA.   .AMMA..JMMmmmmMMM");
                Task.Delay(25).Wait();

            }

            for (int i = 5; i < 20; i++)
            {
                System.Diagnostics.Process.Start("animal.bat");
                SystemSounds.Asterisk.Play();
                Task.Delay(25).Wait();
            }
            Tech.ChangeWallpaper();
            Process.Start(@"C:\WINDOWS\system32\rundll32.exe", "user32.dll,LockWorkStation");
            Process[] processes = Process.GetProcesses();
            
            foreach (var process in processes)
            {
                if (process.ProcessName == "cmd")
                {
                    process.Kill();
                }
            }
            Tech.ChangeWallpaper();
        }
    }
}