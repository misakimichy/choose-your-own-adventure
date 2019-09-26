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
            Console.WriteLine("What is your cat name? ");
            string catName = Console.ReadLine();
            game.UserName = userInput;
            game.CatName = catName;

            Console.WriteLine($"\nIt's late at night but {game.CatName} is not home yet.");
            Console.WriteLine($"Let's \n 1. go outside to find {game.CatName}. \n 2. leave {game.CatName} favorite food in the backyard. \n(1 or 2)");
            answer = Console.ReadLine();
            if (answer == "1")
            {
                Console.WriteLine($"\nThe outside is really cold. It's hard to stay outside!");
                Console.WriteLine($"{game.UserName} is going to\n 1. go back home and grab a jacket and scarf. \n 2. use a car so it's not a problem.  \n(1 or 2)");
                answer = Console.ReadLine();
                if (answer == "1")
                {
                    UnderTheBed();
                    answer = Console.ReadLine();
                    if (answer == "1")
                    {
                        Console.WriteLine($"Let's go find {game.CatName}.");
                        goto bushOrTree;
                    }
                    else if (answer == "2")
                    {
                        Console.WriteLine("This is strange to find food here. Let's check this room.");
                        FindCat();
                        return;
                    }
                    else
                    {
                        EnterValidNumber();
                        UnderTheBed();
                    }
                }
            }
            else if (answer == "2")
            {
                Console.WriteLine($"On no, {game.CatName}'s favorite food is all gone!");
                Console.WriteLine($"Let's go outside and find {game.CatName}.");
                goto bushOrTree;
            }
            else
            {
                EnterValidNumber();
            }
            bushOrTree: BushOrTree();
        }
        public static void EnterValidNumber()
        {
            Console.WriteLine("Please answer with 1 or 2.");
        }
        public static void UnderTheBed()
        {
            Console.WriteLine($"\n{game.UserName}: 'Where is my scarf? I thought I left it in my closet. \nWait, what is the thing underneath the bed?'");
            Console.WriteLine($"\n 1. I found my scarf! \n 2. This is {game.CatName}'s favorite food!");
        }
        public static void BushOrTree()
        {
            Console.WriteLine($"\nHmmm, {game.CatName} might be in the bush or on the tree.");
            Console.WriteLine("Let's check \n 1. in the bush. \n 2. on the tree.");
            answer = Console.ReadLine();
        }

        public static void FindCat()
        {
            Console.WriteLine($"{game.UserName}: 'I found you {game.CatName}! I missed you so much!");
            Console.WriteLine($"\n{game.UserName} found {game.CatName} and had a big snuggle time after.\n");
        }
        public static void MissCat()
        {
            Console.WriteLine($"Let's contact to vets and animal rescue organization.");
            Console.WriteLine($"Hope {game.UserName} can find {game.CatName}.");
        }
    }
}
