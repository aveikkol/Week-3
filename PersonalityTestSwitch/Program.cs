using System;

namespace PersonalityTestSwitch
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
            string userColor = Console.ReadLine().ToLower();

            switch (userColor)
            {
                case "punane":
                    Console.WriteLine("oled romantiline");
                    break;
                case "sinine":
                    Console.WriteLine("oled töökas");
                    break;
                case "roheline":
                    Console.WriteLine("oled looduse sõber");
                        break;
                default:
                    Console.WriteLine($"Oled {userColor} ükssarvik");
                    break;



            }
            Console.WriteLine("Kena päeva!");

        }
    }
}
