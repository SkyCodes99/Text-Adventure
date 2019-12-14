using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TextAdventureTheGame
{
    class ProceedMethod
    {
       public static string proceedInput; //Implement conversion to char
        public static void Proceed()
        {
            Console.WriteLine("Would you prefer A. An automated timer or B. `Enter` key pressed?");
            Thread.Sleep(1000);
            Console.ReadLine();
            proceedInput = Console.ReadLine();
            switch (proceedInput.ToLowerInvariant())
            {
                case "a":
                    EnterKey.LineRead();
                    break;
                case "b":
                    Thread.Sleep(1500);
                    break;
            }
        }

        public static void 
    }
}
