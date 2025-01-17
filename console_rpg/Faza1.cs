using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_rpg
{
    internal class Faza1
    {
        List<string> questions = new List<string> {
            "Did you have a good day? Y/N",
            "Do you have many responsibilities? Y/N",
            "Do you have any pets? Y/N",
            "Have you ever commited a crime? Y/N",
            "Do you know the location of the bodies? Y/N"
        };
        public void Start()
        {
            Console.Clear();
            for (int i = 0; i < (questions.Count - 1); i++)
            {
                Task.Delay(2000).Wait();;
                Console.WriteLine("\n" + questions[i]);
                var check = Tech.KeyCheckResponse(Console.ReadKey().Key);
                if (!check)
                {
                    i--;
                    Task.Delay(4500).Wait();
                }
                Console.Clear();
            }
            Console.WriteLine();
        }
    }
}

