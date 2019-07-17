using System;
namespace Dice_Rolling
{
    public class DiceRolling
    {
        private readonly int userNumber;

        public DiceRolling(int userNumber)
        {
            this.userNumber = userNumber;
        }

        // Creates two random numbers between one and the user's number
        public static void DiceRolls(int userNumber)
        {
            Random randomNumber = new Random();

            int roll1 = randomNumber.Next(1, userNumber);
            int roll2 = randomNumber.Next(1, userNumber);
            Console.WriteLine($"\nYou rolled {roll1} and {roll2}");

            //Lookes at the FancyRolls function and determines if it is null (ie. didn't qualitfy for a fancy roll)
            //if it is not null it will print the message that corresponds to the roll
            var isItFancy = FancyRolls(roll1, roll2);
            if (isItFancy != null)
            {
                Console.WriteLine(isItFancy);
            }
        }

        // Checks to see if the dice in the roll can be applied to any of these
        private static string FancyRolls(int roll1, int roll2)
        {
            if (roll1 == 1 && roll2 == 1)
            {
                return "That's snake eyes!";
            }
            else if (roll1 == 6 && roll2 == 6)
            {
                return "Woot woot you got some boxcars!";
            }
            else if (roll1 + roll2 == 7 || roll1 + roll2 == 11)
            {
                return "You won craps! But that sure isn't crappy!!";
            }
            else
            {
                return null; 
            }
        }
    }
}






