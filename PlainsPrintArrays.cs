using System;
using System.Collections.Generic;
using System.Text;
using TextAdventureTheGame;

namespace TextAdventureTheGame
{
    class PlainsPrintArrays
    {
        public static void plainsPrintOne()
        {
            string[] messageChoiceOne = new string[3] { "You run down the path towards the Plains.",
            "You carefully make your way down the path towards the Plains.", "You walk down the path towards the Plains." };
            Random pathSelectionNumber = new Random();
            int pathNum = pathSelectionNumber.Next(messageChoiceOne.Length);
            Console.WriteLine(messageChoiceOne[pathNum]);
            PlainsOutcomes.PlainsOutcomeScenarioOne();
        }

        public static void plainsPrintTwo()
        {
            
        }
    }
}
