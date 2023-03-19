// Default C# library.
using System;

// Defines the class Program.
// This allows me to use this whole class in a different file.
// It also shows that there can be a whole lot of layers of 
// abstraction.
class Program
{
// Defines the Main function.
    static void Main()
    {
        // This is where the game will be played.

        // This makes a new game.
        var game = new NumberGuessingGame();

        // Calls the play function to begin!
        game.Play();
    }
}

// Defines the class NumberGuessingGame.
class NumberGuessingGame
{
    // Creates the Random functionality.
    // This is done by utilizing a library that another programmer
    // has created to easily generate random numbers.
    private readonly Random _random = new Random();

    // Creates the private int.
    private readonly int _numberToGuess;

    // Creates the private int.
    private int _remainingGuesses;

    // Creates a new instance of NumberGuessingGame class to redefine
    // the _remainingGuesses and _numberToGuess.
    // You can always change these numbers to make it more difficult or easier
    // depending on the person playing.
    public NumberGuessingGame()
    {
        // Defines the _numberToGuess variable by setting a number between
        // 1 or 100. These can be changed to make the game easier or harder.
        _numberToGuess = _random.Next(1, 101);

        // This defines the _remainingGuesses variable by setting how many
        // guesses you have to try and guess the number!
        _remainingGuesses = 5;
    }

    // Defines the Play function.
    public void Play()
    {
        // Makes a loop to tell the player how many remaining
        // guesses they have.
        while (_remainingGuesses > 0)
        {
            // Updates the user on how many guesses they have remaining,
            // each time the program loops.
            Console.WriteLine($"Guess a number between 1 and 100 ({_remainingGuesses} guesses remaining):");
            var guess = int.Parse(Console.ReadLine());

            // If the user guesses the numnber...
            if (guess == _numberToGuess)
            {

                // Prints the following line:
                Console.WriteLine("Congratulations, you guessed the number!");
                return;
            }

            // Subrtacts the _remainingGuesses by one each loop.
            _remainingGuesses--;


            // If _remaingGuesses is 0...
            if (_remainingGuesses == 0)
            {
                // You lose!
                Console.WriteLine($"Sorry, you ran out of guesses. The number was {_numberToGuess}.");
                return;
            }

            // If guess is less than _numberToGuess...
            if (guess < _numberToGuess)
            {
                // Prints the following statement:
                Console.WriteLine("Too low!");
            }

            // If guess is greater than _numberToGuess...
            else
            {
                // Prints the following statement:
                Console.WriteLine("Too high!");
            }
        }
    }
}