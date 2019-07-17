using System;

namespace Dice_Rolling
{
    class DiceRollingTest
    {
        static void Main(string[] args)
        {
            string rollAgain = "Y";
            Console.WriteLine("Welcome to the Dice Roll! Would you like to roll the dice? Y/N.");
            string userAnswer = Console.ReadLine().ToUpper();
            do
            {
                // Ask the user how many sides they want their dice to have
                // Check to make sure the user has entered a valid number
                // and if they don't, ask them to enter another one
                Console.WriteLine("How many sides do you want your die to have?");
                try
                {
                    int userNumber = int.Parse(Console.ReadLine());
                    Console.WriteLine(DiceRolling.DiceRolls(userNumber));
                }
                catch
                {
                    Console.WriteLine("Invalid.  Please try again.");
                    continue;
                }

                // Ask user if they want to roll again, if they don's the 
                //program will end, if they do it will continue
                Console.WriteLine("\nWould you like to roll again? Y/N");
                rollAgain = Console.ReadLine().ToUpper();

            } while (rollAgain == "Y");
            Console.WriteLine("Thank you for rolling with us!");
        } 
    }
}

