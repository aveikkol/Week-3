using System;

namespace PersonalityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada tema lemmikvärv
            //kui kasutaja sisestab punane, konsool kuvab, et oled romantiline;
            //kui kasutaja sisestab sinine, konsool kuvab, et oled töökas;
            //kui kasutaja sisestab roheline, konsool kuvab, et oled looduse sõber;
            //kui kasutaja sisestab midagi muud, konsool kuvab, et oled ükssarvik;

            Console.WriteLine("Sisesta oma lemmikvärv:");
            string userColor = Console.ReadLine();

            if (userColor == "punane")
            {
                Console.WriteLine("Oled romantiline");

            }
            else if(userColor == "sinine")
            {
                Console.WriteLine("Oled töökas");
            }
            else if(userColor == "roheline")
            {
                Console.WriteLine("Oled looduse sõber");
            }
            else
            {
                Console.WriteLine($"Oled {userColor} ükssarvik");
            }

            Console.WriteLine("Kena päeva!");

            


        }
    }
}
