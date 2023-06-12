using System.Collections.Generic;

namespace ConsoleApp4
{
    internal class Program
    {
        public static readonly Random rnd = new Random();
        public const int GUESS_LIMIT = 6;

        static void Main(string[] args)
        {
            //introduction to the program
            Console.WriteLine("Welcome to the game of Hangman!");
            Console.WriteLine("You will be guessing letters inside of the secret word...");
            Console.WriteLine($"You have the right to {Program.GUESS_LIMIT} wrong guesses!");
            Console.WriteLine("Lets go!");

            //creating a list with strings that are been used as guessing words
            List<string> words = new List<string>() { "mayhem", "chaos", "destruction" };
            //block of code that is randomly picking string out of the list
            int randomIndex = rnd.Next(words.Count);
            string randomWord = words[randomIndex];
            //creating an array of char. to visualy display and build our guessing word through the program 
            char[] guessedWord = new char[randomWord.Length];
            for (int i = 0; i < guessedWord.Length; i++)
            {
                guessedWord[i] = '_';
                Console.Write(guessedWord[i]);
            }
            Console.WriteLine();

            int numOfWrongGuesses = 0;
            bool guessedRight = true;
            //usign while loop to loop through conditions until one occurs
            while (guessedRight)
            {
                //asking for input and checking if entered input exists in randomly picked word which we store in a boolean
                char guessingLetter = Console.ReadKey().KeyChar;
                Console.WriteLine();
                bool charExists = false;
                //using the condition of boolean to procced with building our word or...*
                for (int i = 0; i < randomWord.Length; i++)
                {
                    if (randomWord[i] == guessingLetter)
                    {
                        charExists = true;
                        guessedWord[i] = guessingLetter;
                    }
                }

                if (charExists)
                {
                    Console.WriteLine(guessedWord);
                    //buiding an string out of char array to be able to check if player guessed the randomly picked word
                    string guessedWordString = new string(guessedWord);
                    if (guessedWordString == randomWord)
                    {
                        guessedRight = true;
                        break;
                    }
                    Console.WriteLine("Nice guess!");
                    Console.WriteLine("Keep it going...\n");
                }
                else //...*stop and count wrong guess
                {
                    numOfWrongGuesses++;
                    Console.WriteLine("Secret word doesnt contain the letter you provided!");
                    //checking if player player exceeded the limit of wrong guesses
                    if (numOfWrongGuesses >= Program.GUESS_LIMIT)
                    {
                        guessedRight = false;
                        break;
                    }
                    Console.WriteLine($"You have {Program.GUESS_LIMIT - numOfWrongGuesses} shots left.");
                    Console.WriteLine("Try again...\n");
                }
            }

            if (!guessedRight)
            {
                Console.WriteLine("You lost the game!");
            }
            else
            {
                Console.WriteLine("You won the game!");
            }
        }
    }
}