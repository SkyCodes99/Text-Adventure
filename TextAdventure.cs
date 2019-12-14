using System;
using System.IO;
using System.Threading;
using TextAdventureTheGame;

namespace TextAdventureTheGame
{
    public class TextAdventure
    {
        public static void Start()
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Welcome to Text Adventure!");
            EnterKey.LineRead();
            Console.WriteLine("You are playing on version Alpha 0.0.0.1");
            EnterKey.LineRead();
            Console.WriteLine("Choose a Path");
            EnterKey.LineRead();
            Console.WriteLine("Plains, Forest, or Cave");
            PathSelection();
        }
        public static void PathSelection()
        {
            Boolean Finished = false;
            do
            {
                String pathDecision = Console.ReadLine(); //Ask the user for input on which path should be taken
                switch (pathDecision.ToLowerInvariant()) //Sets the path based on the user response
                {
                    case "plains":
                        Console.WriteLine("You have chosen to take the 'Plains' path.");
                        Plains.ThePlains();
                        Finished = true;
                        break;
                    case "forest":
                        Console.WriteLine("You have chosen to take the 'Forest' path.");
                        break;
                    case "cave":
                        Console.WriteLine("You have chosen to take the 'Cave' path.");
                        break;
                    case "random":
                        RandomPath.pathOfRandom();
                        break;
                    default:
                        Console.WriteLine("Try Again"); //Needs to be fixed where it doesn't go throughout the program
                        break;
                }
            } while (!Finished);
        }
        public static void Main(String[] args)
        {
            Start();
        }
    }
}

/*
 * 1. Start the program with an introduction
 * 2. Create a function which has the user pick between the Plains, Forest, or Cave path (Possible Easter Egg Path)
 * 3. Create a class for each path and another class for any code that is printed numerous times
 * 4. Use arrays with random number generators and switch statements to switch up the path
 */

