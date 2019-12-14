using System;

namespace TextAdventureTheGame
{
    class Plains
    {
        public static void ThePlains()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            PlainsPrintArrays.plainsPrintOne(); //Calls the plainsPrintOne | Print #1
        }

        public static void plainsPrintTwoOutcomeOne()
        {
            EnterKey.LineRead();
            Console.WriteLine("The sun is shining and you hear birds chirping nearby.");
            EnterKey.LineRead();
            Console.WriteLine("There are flowers that have recently bloomed giving off the most pleasant of smells.");
            EnterKey.LineRead();
            Console.WriteLine("Do you pick a flower?");
            Console.WriteLine("Yes or No");
            PlainsOutcomes.plainsOutcomeScenarioTwo();
        }
        public static void plainsPrintTwoOutcomeTwo()
        {
            EnterKey.LineRead();
            Console.WriteLine("");
            EnterKey.LineRead();
            Console.WriteLine("");
        }
        public static void plainsPrintTwoOutcomeThree()
        {
            EnterKey.LineRead();
            Console.WriteLine("");
            EnterKey.LineRead();
            Console.WriteLine("");
        }
    }
}
