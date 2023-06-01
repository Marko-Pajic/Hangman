using System.Collections.Generic;

namespace ConsoleApp4
{
    internal class Program
    {
        public static readonly Random rnd = new Random();
        public const int GUESS_LIMIT = 6;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the game of Hangman!");
            Console.WriteLine("You will be guessing letters inside of the secret word...");
            Console.WriteLine($"You have the right to {Program.GUESS_LIMIT} wrong guesses!");
            Console.WriteLine("Lets go!");
            List<string> words = new List<string>() { "mayhem", "chaos", "destruction" };
            int randomIndex = rnd.Next(words.Count);
            string randomWord = words[randomIndex];
            char[] guessedWord = new char[randomWord.Length];
            for (int i = 0; i < guessedWord.Length; i++)
            {
                guessedWord[i] = '_';
                Console.Write(guessedWord[i]);
            }
            Console.WriteLine();
            int wrongGuess = 0;
            bool guessedRight = false;
            while (true)
            {
                char guessingLetter = Console.ReadKey().KeyChar;
                Console.WriteLine();
                bool charExists = randomWord.Contains(guessingLetter);
                if (charExists)
                {
                    for (int i = 0; i < randomWord.Length; i++)
                    {
                        if (randomWord[i] == guessingLetter)
                        {
                            guessedWord[i] = guessingLetter;
                        }
                    }
                    Console.WriteLine(guessedWord);
                    Console.WriteLine("Nice guess!");
                    Console.WriteLine("Keep it going...");
                }
                else
                {
                    wrongGuess++;
                    Console.WriteLine("Secret word doesnt contain the letter you provided!");
                    Console.WriteLine($"You have {Program.GUESS_LIMIT - wrongGuess} shots left.");
                    Console.WriteLine("Try again...");
                }
                if (wrongGuess >= Program.GUESS_LIMIT)
                {
                    break;
                }
                string allCharExist = new(guessedWord);
                if (allCharExist == randomWord)
                {
                    guessedRight = true;
                    break;
                }
            }
            if (guessedRight)
            {
                Console.WriteLine("You won the game!");
            }
            else
            {
                Console.WriteLine("You lost the game!");
            }
        }
    }
}