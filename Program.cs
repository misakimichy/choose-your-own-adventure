using System;
using ChooseYourScenario.Models;

namespace ChooseYourScenario
{
    class Program
    {
        public static Game game = new Game();
        public static void Main()
        {
            Console.WriteLine("Welcomde to Find Your Cat!");
            Console.WriteLine("You're going to select choices and make your own senario.");
            Console.WriteLine("Please enter your name to start.");
            Console.WriteLine("Your name: ");
            string userInput = Console.ReadLine();
            Console.WriteLine("Name your cat: ");
            string catName = Console.ReadLine();
            game.UserName = userInput;
            game.CatName = catName;
        }
    }
}
