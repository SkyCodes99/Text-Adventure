using System;
using System.Threading;
using System.Diagnostics;

namespace TextAdventureTheGame
{
    class PlainsOutcomes
    {
        public static void PlainsOutcomeScenarioOne()
        {
            Random numGen = new Random();
            int numResult = numGen.Next(1, 1);
            switch (numResult)
            {
                case 1:
                    Plains.plainsPrintTwoOutcomeOne();
                    break;
                case 2:
                    Plains.plainsPrintTwoOutcomeTwo();
                    break;
                case 3:
                    Plains.plainsPrintTwoOutcomeThree();
                    break;
                default:
                    Console.WriteLine(numResult);
                    break;
            }
        }
        public static void plainsOutcomeScenarioTwo()
        {
            string Decision = Console.ReadLine();
            if (Decision == "yes")
            {
                Console.WriteLine("You pick the flower and it turns out to be poisionous. Your arm swells and within three minutes you will die.");
                Console.WriteLine("You frantically try your best to run further down the path for around two minutes, but it seems you're out of luck.");
                Console.WriteLine("There's only thirty seconds left until you die. Suddenly, a figure appears and offers you two hard candies.");
                Console.WriteLine("\"Choose a candy, Blue or Red. The time is ticking, 15 seconds remaining.\"");
                Stopwatch sw = new Stopwatch();
                sw.Start();
                TimeSpan timeSpan = sw.Elapsed;
                    while (sw.Elapsed <= TimeSpan.FromSeconds(10))
                {
                    Console.WriteLine("Test");
                    string colorChoice = Console.ReadLine();
                    if (timeSpan.Seconds >= 10)
                    {
                        Console.WriteLine("You have run out of time.");
                        Loser.GameOver();
                    }
                    else if(colorChoice.ToLowerInvariant() == "blue")
                    {
                        sw.Stop();
                        Console.WriteLine("Blue");
                        return;
                    }
                    else if(colorChoice.ToLowerInvariant() == "red")
                    {
                        sw.Stop();
                        Console.WriteLine("Red");
                        return;
                    }
                }
            }
        }
    }
}
