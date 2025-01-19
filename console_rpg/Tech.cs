using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Microsoft.Win32;
using System.Runtime.InteropServices;

namespace survey_game
{
    internal class Tech
    {
        public static string commandPrompt = $"{Environment.UserName}@{Environment.MachineName}:~$  ";
        public static List<ConsoleKey> answers = new List<ConsoleKey> { ConsoleKey.Y, ConsoleKey.N };
        public const int SPI_SETDESKWALLPAPER = 20;
        public const int SPIF_UPDATEINFILE = 1;
        public const int SPIF_SENDCHANGE = 2;

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);

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
                    string progIdValue = userChoiceKey.GetValue("Progid").ToString().ToLower();
                    if (progIdValue != null)
                    {
                        if (progIdValue.Contains("chrome"))
                        {
                            return "chrome.exe";
                        }
                        else if (progIdValue.Contains("firefox"))
                        {
                            return "firefox.exe";
                        }
                        else if (progIdValue.Contains("safari"))
                        {
                            return "safari.exe";
                        }
                        else if (progIdValue.Contains("opera"))
                        {
                            return "opera.exe";
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
                else
                {
                    return null;
                }
            }
        }
        public static void ChangeWallpaper()
        {
            string imgPath = Environment.CurrentDirectory + @"\murder_site.jpg";
            SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, imgPath, SPIF_UPDATEINFILE | SPIF_SENDCHANGE);
        }
    }
}