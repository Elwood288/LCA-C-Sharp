using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get word from user
            Console.WriteLine("Give me a word to translate.");
            string userWord = Console.ReadLine();
            //translate to Pig Lating
            string convertedWord = PigLatin(userWord);
            Console.WriteLine(convertedWord);
            Console.Read();
        }

        public static string PigLatin(string word)
        {   
            // Check if first letter is a vowel
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            string currentVowel = "";
            //int firstVowelIndex = userWord.IndexOfAny(vowels);
            //string firstLetter = userWord.Substring(0);

            bool startWithVowel = false;
            bool endWithVowel = false;
            

            if (-1 >= word.IndexOfAny(vowels))
            {
                return (word + "ay");
                
            }
            else
            {
                for (int i = 0; i < vowels.Length - 1; i++)
                {
                    currentVowel = vowels[i].ToString();
                    if (word.StartsWith(currentVowel))
                    {
                        startWithVowel = true;
                        
                    }

                    if (word.EndsWith(currentVowel))
                    {
                        endWithVowel = true;
                        
                    }

                    //if (word.IndexOfAny(vowels) > -1)
                    //{
                    //    foundVowel = true;
                    //}

                }

            }

            if (startWithVowel && endWithVowel)
            {
                return (word + "yay");
            }
           
            else
            {
                int firstVowelPosition = word.IndexOfAny(vowels);
                string firstHalf = word.Substring(0, firstVowelPosition);
                string secondHalf = word.Substring(firstVowelPosition);
                return (secondHalf + firstHalf + "ay");
            }
        }
    }
}
