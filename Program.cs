using System;
using ChooseYourScenario.Models;

namespace ChooseYourScenario
{
    class Program
    {
        public static Game game = new Game();
        public static string answer = "";
        public static void Main()
        {
            Console.WriteLine("Welcomde to Find Your Cat!");
            Console.WriteLine("You're going to select a story that you like and make your own senario.\n Please answer with 1 or 2.");
            Console.WriteLine("Please enter your name to start.");
            Console.WriteLine("Your name: ");
            string userInput = Console.ReadLine();
            Console.WriteLine("Name your cat: ");
            string catName = Console.ReadLine();
            game.UserName = userInput;
            game.CatName = catName;

            Console.WriteLine($"\nIt's late at night but {game.CatName} is not home yet.");
            Console.WriteLine("Are you \n 1. going outside to find her? \n 2. going to leave her favorite food in the backyard? \n(1 or 2)");
            answer = Console.ReadLine();
            if (answer == "1")
            {
                Console.WriteLine("\nThe outside is really cold. I cannot stay outside!");
                Console.WriteLine("I'll \n 1. go back home and grab a jacket and scarf. \n 2. use a car so it's not a problem.  \n(1 or 2)");
                answer = Console.ReadLine();
                if (answer == "1")
                {
                    Console.WriteLine("\nWhere is my scarf? I thought I left in my closet.");
                    Console.WriteLine("Wait, what is the thing underneath the bed?");
                    Console.WriteLine($"\n 1. I found my scarf! \n 2. This is {game.CatName}'s favorite food!");
                    answer = Console.ReadLine();
                    if(answer == "1")
                    {
                        Console.WriteLine("Let's go find her.");
                        goto done;
                    }
                }
                done: bushOrTree();
            }
            else if (answer == "2")
            {
                Console.WriteLine($"On no, {game.CatName}'s favorite food is all gone!");
            }
        }
        public static void bushOrTree()
        {
            Console.WriteLine($"\nHmmm, {game.CatName} might be in the bush or on the tree.");
            Console.WriteLine("Let's check \n 1. in the bush. \n 2. on the tree.");
        }
    }
}
