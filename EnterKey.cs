using System;
using System.Collections.Generic;
using System.Text;

namespace TextAdventureTheGame
{
    class EnterKey
    {
        public static void LineRead() //Method that checks for Enter Key being pressed
        {
            do
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true); //Checks for a key pressed
                if (keyInfo.Key == ConsoleKey.Enter) //If the key keyInfo is the "Enter" key
                {
                    break;
                }
            } while (true);  //While the key is not "Enter" being pressed it will do nothing.
        }
    }
}
