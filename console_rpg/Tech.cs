using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Microsoft.Win32;

namespace survey_game
{
    internal class Tech
    {
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

        public static string getDefaultBrowser()
        {
            using (RegistryKey userChoiceKey = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\Shell\Associations\UrlAssociations\http\UserChoice"))
            {
                if (userChoiceKey != null)
                {
                    object progIdValue = userChoiceKey.GetValue("Progid");
                    if (progIdValue != null)
                    {
                        if (progIdValue.ToString().ToLower().Contains("chrome"))
                            return "chrome.exe";
                        else if (progIdValue.ToString().ToLower().Contains("firefox"))
                            return "firefox.exe";
                        else if (progIdValue.ToString().ToLower().Contains("safari"))
                            return "safari.exe";
                        else if (progIdValue.ToString().ToLower().Contains("opera"))
                            return "opera.exe";
                        else
                            return null;
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }
        }
    }
}