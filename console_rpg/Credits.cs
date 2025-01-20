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
            String credits = "Director: Tomáš Koštial \n Assistent director: Šarlota Gallovičová \n Graphic designer: Teodor Šutara \n Programers: Tomáš Koštial, Teodor Šutara, Šarlota Gallovičová";
            
            Console.Clear();
            
            for (int i = 0; i < monologue.Count; i++)
            {
                foreach (char j in monologue[i])
                {
                    Console.Write(j);
                    Task.Delay(75).Wait();
                }
                Console.Write("\n");
                if (i == monologue.Count - 1)
                {
                    Task.Delay(1000).Wait();
                }
                else
                {
                    Task.Delay(2500).Wait();
                }
            }

            Console.WriteLine("\n\n\n" + credits);
        }
    }
}