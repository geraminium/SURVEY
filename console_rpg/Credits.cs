using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_rpg
{
    internal class Credits
    {
        public static void Roll()
        {
            List<string> monologue = new List<string>()
            {
                "Now...",
                "If it were really you, who killed poor Livia...",
                "...would you be happy with the aftermath?",
                "Imagine the pain,...",
                "the struggle,...",
                "the grief that her parents went through.",
                "The feeling of her friends when they realize they will never see her again...",
                "Think before you act.",
                "Thanks for playing!"
            };
            String credits = "Director: Tomáš Koštial \n Programers: Tomáš Koštial, Teodor Šutara, Šarlota Gallovičová \n Graphic designer: Teodor Šutara \n Directive assistent: Šarlota Gallovičová";
            for (int i = 0; i < monologue.Count; i++)
            {
                foreach(char j in monologue[i])
                {
                    Console.Write(j);
                    Task.Delay(75);
                }
                Console.Write("\n");
                Task.Delay(4500).Wait();
            }
            Console.WriteLine(credits);
        }
    }
}
