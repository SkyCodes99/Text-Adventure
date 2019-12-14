using System;
using System.Collections.Generic;
using System.Text;
using TextAdventureTheGame;

namespace TextAdventureTheGame
{
    class RandomPath
    {
        public static void pathOfRandom()
        {
        string[] pathSelectionArray = new string[3] { "Plains", "Forest", "Cave" };
        Random pathSelectionNumber = new Random();
        int pathNum = pathSelectionNumber.Next(pathSelectionArray.Length);
        Console.WriteLine("You have chosen " + pathSelectionArray[pathNum]);
                        if(pathNum == 0)
                        {
                            Plains.ThePlains();
                        }
                        else if(pathNum == 1)
                        {
                            Forest.TheForest();
                        }
                        else if(pathNum == 2)
                        {
                            Cave.TheCave();
                        }
                        else
                        {
                            Console.WriteLine("Error");
                        }
        }
    }
}
