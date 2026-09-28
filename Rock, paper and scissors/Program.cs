using System;
using System.ComponentModel.Design;
using System.Security;
using Microsoft.VisualBasic;
internal class Program
{
    static void Main()
    {
        int cock = 0;
        bool Game = true;
        // Simple game of Rock, Paper, Scissors
        Console.WriteLine("Welcome to the game of Rock, Paper, Scissors");
        Console.WriteLine("The rules are simple: \nScissors wins Paper, Rock wins Scissors and Paper wins Rock");
        Console.WriteLine("If you want to end the game, just type \"End\"");
        Console.WriteLine("If you need to see the rules again, just type \"Help\"");
        Console.WriteLine("\nYou go first!");
        
        //Game starts here
        while (Game)
        {
            Console.WriteLine("\nPlayer choice: ");
            //Player types their choice
            string Player = Console.ReadLine();

            if (string.Equals(Player, "rock", StringComparison.CurrentCultureIgnoreCase))
            {
                Rocks();
            }

            else if (string.Equals(Player, "paper", StringComparison.CurrentCultureIgnoreCase))
            {
                Paper();
            }

            else if (string.Equals(Player, "scissors", StringComparison.CurrentCultureIgnoreCase))
            {
                Scissors();
            }

            //When player types chicken
            else if (string.Equals(Player, "chicken", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine(" (@<");
                Console.WriteLine("(< )");
                Console.WriteLine(" `´ ");

                Console.WriteLine("It's a chicken...");
                Console.WriteLine("We could continue the game...right?");
            }

            //When player types cock, and if 3 types the game ends and a secret game starts
            else if (string.Equals(Player, "cock", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("  # ");
                Console.WriteLine(" (@<");
                Console.WriteLine("(< )");
                Console.WriteLine(" `´ ");

                Console.WriteLine("You really thought to see a different kind of rooster...didn't you");
                Console.WriteLine("You...Are...A...Pervert");

                cock++;
                //Console.WriteLine(cock);
            }

            //Ending the game
            else if (string.Equals(Player, "end", StringComparison.CurrentCultureIgnoreCase))
            {
                End();
                Game = false;
            }
            //Player needing to see rules
            else if (string.Equals(Player, "help", StringComparison.CurrentCultureIgnoreCase))
            {
                Help();
            }
            //If player doesn't type correctly
            else 
            {
                Console.WriteLine("The word isn't correct, please check for writing mistakes.");
            }
            
            //When cock has been typed 3 times in the game session
            if (cock == 3)
            {
                Console.Clear();
                
                SecretGame();
            }
             
        }
    }

    //The game choices are checked here
    //Rock() methods includes players choice Rock and the pc randomaizer
    static void Rocks()

    {
        string[] words = new string[] { "Rock", "Paper", "Scissors" };
        string Pc = words[new Random().Next(0, words.Length)];


        if (Pc == "Rock")
        {
            Console.WriteLine("Pc Choose " + Pc);
            Console.WriteLine("Its a Tie, try again!");
            return;
        }

        else if (Pc == "Paper")
        {
            Console.WriteLine("Pc Choose " + Pc);
            Console.WriteLine("Hehe I Win!");
            return;
        }

        else if (Pc == "Scissors")
        {
            Console.WriteLine("Pc Choose " + Pc);
            Console.WriteLine("Ahhh, You Win!");
            return;
        }
    }
    
    //Paper() methods includes players choice Paper and the pc randomaizer
    static void Paper()
    {
        string[] words = new string[] { "Rock", "Paper", "Scissors" };
        string Pc = words[new Random().Next(0, words.Length)];

        if (Pc == "Paper")
        {
            Console.WriteLine("Pc Choose " + Pc);
            Console.WriteLine("Its a Tie, try again!");
            return;
        }

        else if (Pc == "Rock")
        {
            Console.WriteLine("Pc Choose " + Pc);
            Console.WriteLine("Ahhh, You Win!");
            return;
        }

        else if (Pc == "Scissors")
        {
            Console.WriteLine("Pc Choose " + Pc);
            Console.WriteLine("Hehe I Win!");
            return;
        }
    }

    //Scissors() methods includes players choice Scissors and the pc randomaizer
    static void Scissors()
    {
        string[] words = new string[] { "Rock", "Paper", "Scissors" };
        string Pc = words[new Random().Next(0, words.Length)];

        if (Pc == "Scissors")
        {
            Console.WriteLine("Pc Choose " + Pc);
            Console.WriteLine("Its a Tie, try again!");
            return;
        }

        else if (Pc == "Rock")
        {
            Console.WriteLine("Pc Choose " + Pc);
            Console.WriteLine("Hehe I Win!");
            return;
        }

        else if (Pc == "Paper")
        {
            Console.WriteLine("Pc Choose " + Pc);
            Console.WriteLine("Ahhh, You Win!");
            return;
        }

        
    }
    
    //Method for ending the game
    static void End()
    {
        Console.WriteLine("Are youy sure you want to End the Game Y/N ??");
        var response = Console.ReadKey(false).Key;
        Console.ReadLine();

        if (response == ConsoleKey.Y && response != ConsoleKey.N)
        {
           return;
        }

        else if (response == ConsoleKey.N && response != ConsoleKey.Y)
        {
            Console.WriteLine("Let's continue the game!");
            Main();
        }

        else
        {
            Main();
        }
    }

    //If the player needs to see the rules or needs help exiting the game
    static void Help()
    {
        Console.WriteLine("\nThe rules are simple: \nScissors wins Paper, Rock wins Scissors and Paper wins Rock");
        Console.WriteLine("If you want to end the game, just type \"End\"");
        Console.WriteLine("If you need to see the rules again, just type \"Help\"");
    }

    //SecretGame is here, when the player says cock 3 times
    static void SecretGame()
    {
        Console.WriteLine("Welcome my friend, I see you disscovered my secret game...");
        Console.WriteLine("Ha ha ha ah aha ha \"couch\" \"couch\" \"couch\"");
        Console.WriteLine("Let's begin... shall we...");

        Console.ReadLine();
    }
}

