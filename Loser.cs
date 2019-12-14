using System;
using System.Threading;
using System.Diagnostics;

namespace TextAdventureTheGame
{
    class Loser
    {
        public static void GameOver()
        {
            Console.WriteLine("Your story ends here.");
            Thread.Sleep(1000);
            Restart();
            
        }
        public static void Restart()
        {
            Console.WriteLine("You may close the window or the game will automatically restart in 10 seconds.");
            Stopwatch sw = new Stopwatch();
            sw.Start();
            while (sw.Elapsed <= TimeSpan.FromSeconds(10))
            {
                Thread.Sleep(1000);
            }
            sw.Stop();
            TextAdventure.Start();
        }
    }
}
