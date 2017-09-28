using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus3
{
    class Program
    {
        static void Main(string[] args)
        {
            //application will prompt user for a number between 1 and 100
            //user will guess the number
            //application will display a message to indicate if the guess is too high or too low
            //when the user guesses the number, the application will display how many tries it took to get it right
            //application will prompt user to play again
            //if user chooses to end the game, the application will display a goodbye message

            int x; //the number entered by user. 
            //different variable for computer's guess? random within a range/Google it!

            Console.WriteLine("Welcome to the Guess a Number Game!");

            Console.WriteLine("+++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("I'm thinking of a number between 1 and 100!");

            Console.WriteLine("Try your best, if you dare! Enter your guess:");
            x = int.Parse(Console.ReadKey());

            if ((x > 100) || (x < 1)) ;
            {
                Console.WriteLine("I said between 1 and 100. Maybe you should check your eyes! Try again."); //loop back? Move method?
            }
            else
            {
                return DataResult; //another method containing result and if guess is correct/how many tries it took
            }
        }
    }
}
