# Hangman Game

A simple and fun hangman game in C#. Guess the letters of the secret word and try to avoid being hanged.

## Table of Contents

- Hangman Game
- Table of Contents
- Motivation
- Installation
- Usage
- Technologies
- Acknowledgements
- License
- Contact

## Motivation

I created this project as a way to practice my C# skills and learn more about console applications. I wanted to create a simple and fun game that simulates the classic hangman game. The game features a list of words, a random word generator, a user input handler, and a game logic controller.

## Installation

To download, install, and run this project, you will need:

- Visual Studio 2019 or later
- .NET Framework 4.7.2 or later
- Windows 10 or later

You can clone this project from GitHub using the following command:

`git clone https://github.com/your-username/hangman-game.git`

Alternatively, you can download the ZIP file from the GitHub repository and extract it to your desired location.

To open the project in Visual Studio, double-click on the `ConsoleApp4.sln` file in the root folder.

To run the project, press F5 or click on the Start button in Visual Studio.

## Usage

To play the game, follow these steps:

- Read the introduction and the rules of the game. You will be guessing letters inside of the secret word. You have the right to 6 wrong guesses.
- Press any key to start the game. You will see the secret word as a series of underscores and the number of wrong guesses left.
- Enter a letter and press Enter. You will see if the letter exists in the secret word or not.
- If the letter exists, it will be revealed in the secret word. If the letter does not exist, you will lose one wrong guess.
- Repeat the process until you either guess the secret word or run out of wrong guesses.
- You will see a message showing whether you won or lost the game and the secret word.

Here are some screenshots of the game:

![Screenshot 1]
![Screenshot 2]
![Screenshot 3]

## Technologies

I used the following technologies, tools, and frameworks to create this project:

- C# as the programming language
- Visual Studio 2019 as the integrated development environment
- .NET Framework 4.7.2 as the software framework
- System.Console as the console input and output class
- System.Random as the random number generator class
- System.Collections.Generic.List as the generic list class

Some of the challenges or difficulties that I faced and how I overcame them are:

- Creating a list of words to use as the secret words. I used a hard-coded list of strings to store the words and a random number generator to select a random word from the list.
- Creating a char array to display and update the secret word. I used a for loop to initialize the array with underscores and another for loop to replace the underscores with the guessed letters.
- Checking for the user input and the game outcome. I used a while loop to keep the game running until a condition is met and a boolean variable to store the result of the user input.
- Handling invalid or repeated user input. I used a try-catch block to catch any exceptions and a if-else statement to check if the user input has already been entered.

## Acknowledgements

I would like to thank or credit the following sources, references, or inspirations that helped me with this project:

- [Microsoft Docs] for providing the documentation and tutorials for C#, Visual Studio, .NET Framework, and System classes.
- [Rakete Mentoring] for providing the answers and solutions to various programming questions and problems.
- [Wikipedia] for providing the information and history of the hangman game.

## License

This project is licensed under the MIT License. See the [LICENSE] file for more details.

## Contact

If you want to connect with me or have any questions or feedback about this project, you can reach me at:

- Email: pajic.marko84@gmail.com
