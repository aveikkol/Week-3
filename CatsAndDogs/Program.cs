using System;

namespace CatsAndDogs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Are you more like cat or a dog?");
            string userChoice = Console.ReadLine().ToUpper();

            if (userChoice == "CAT")
            {
                Console.WriteLine("You are home-lover");
            }
            else if (userChoice == "DOG")
            {
                Console.WriteLine("You are partygoer ");
            }
            else
            {
                Console.WriteLine($"You are {userChoice} friend");
            }
        }
    }
}