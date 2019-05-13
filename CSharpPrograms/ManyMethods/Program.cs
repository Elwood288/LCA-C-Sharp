using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //hello method
            //hello();
            //addition();
            //catDog();
            //oddEvent();
            //inches();
            //echo();
            //killGrams();
            //date();
            //age();
            //guess();
        }

        public static void hello()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Bye " + name);
            Console.Read();
        }

        public static void addition()
        {
            Console.WriteLine("Please enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("The sum is " + (num1 + num2));
            Console.Read();
        }

        static void catDog()
        {
            Console.WriteLine("Do you like cats or dogs? ");
            string choice = Console.ReadLine();


            if (choice == "cats")
            {
                Console.WriteLine("Meow");
            }
            else
            {
                Console.WriteLine("Woof");
            }
            Console.Read();
        }

        static void oddEvent()
        {
            int userNumber = 0;
            Console.WriteLine("Please enter a number: ");
            userNumber = int.Parse(Console.ReadLine());
            if (userNumber % 2 == 0)
            {
                Console.WriteLine("The number is even.");
            }
            else
            {
                Console.WriteLine("The number is odd.");
            }
            Console.Read();
        }

        static void inches()
        {
            Console.WriteLine("Please enter a length in feet. ");
            int feet = int.Parse(Console.ReadLine());
            Console.WriteLine(feet + " feet is equal to " + (feet * 12) + " inches");
            Console.Read();
        }

        static void echo()
        {
            Console.WriteLine("Please enter a word to be echoed.");
            string echoWord = Console.ReadLine();
            string upperEchoWord = echoWord.ToUpper();
            Console.WriteLine(upperEchoWord + " " + echoWord + " " + echoWord);
            Console.Read();

        }

        static void killGrams()
        {
            Console.WriteLine("Please enter a weight in pounds. ");
            double pounds = double.Parse(Console.ReadLine());
            double kilograms = pounds * 0.45;
            Console.WriteLine(pounds + " pounds is equal to " + kilograms + " kilograms");
            Console.Read();
        }

        static void date()
        {
            Console.Write("Current Date and Time is : ");
            DateTime now = DateTime.Now;
            Console.WriteLine(now);
            Console.ReadLine();
        }

        static void age()
        {
            Console.Write("What year were you born? ");
            int birthYear = int.Parse(Console.ReadLine());
            Console.WriteLine("You are " + (2019 - birthYear) + " years old.");
            Console.ReadLine();
        }

        static void guess()
        {
            Console.WriteLine("Guess the word ");
            string userGuess = Console.ReadLine();
            if (userGuess == "chsarp")
            {
                Console.WriteLine("Correct.");
            }
            else
            {
                Console.WriteLine("Wrong.");
            }
            Console.Read();
        }
    }
}
