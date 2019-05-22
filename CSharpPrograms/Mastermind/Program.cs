using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind
{
    class Program
    {
        static string[] answer = new string[2];
        static string[] colors = new string[] { "red", "blue", "yellow" };
        
        static void Main(string[] args)
        {
            Random rnd = new Random();
            for (int i = 0; i < 2; i++)
            {
                answer[i] = colors[rnd.Next(0,3)];
            }


            // Ask for guess
            Console.WriteLine("Make your guess.");
            string[] guess = Console.ReadLine().Split(' ');

            while( IsCorrectAnswer(guess) == false)
            {
                Console.WriteLine("Make your guess.");
                guess = Console.ReadLine().Split(' ');
            }
        }
      






        public static bool IsCorrectAnswer(string[] userGuess)
        {
            //Check if guess is correct
            if (userGuess[0] == answer[0] && userGuess[1] == answer[1])
            {
                Console.WriteLine("You win");
                Console.Read();
                return true;
            }
            else
            {
                int correctColorCount = 0;
                int correctPositionCount = 0;

                for (int i = 0; i < 2; i++)
                {
                    if (answer.Contains(userGuess[i]))
                    {
                        correctColorCount++;
                    }
                }


                for (int i = 0; i < 2; i++)
                {
                    if (userGuess[i] == answer[i])
                    {
                        correctPositionCount++;
                    }
                }

                Console.WriteLine("Of the colors you guessed " +correctColorCount + " colors are correct and " + correctPositionCount + " positions are correct.");
                return false;
            }
        }
    }
}
