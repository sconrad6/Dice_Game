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
        public static string DiceRolls(int userNumber)
        {
            Random randomNumber = new Random();

            int roll1 = randomNumber.Next(1, userNumber);
            int roll2 = randomNumber.Next(1, userNumber);
            Console.WriteLine($"\nYou rolled {roll1} and {roll2}");

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
            } else
            {
                return "";
            }
        }
    }
}
