string greeting = @"Welcome to Guessing Game! Guess the secret number to win!";
Console.WriteLine(greeting);

Random random = new Random();
int secretNumber = random.Next(1, 101);

int NumberOfGuesses = 0;
int guessesAllowed = 0;

Console.WriteLine("Choose a difficulty level by entering number:  1. Easy, 2. Medium, 3. Hard, 4. Cheater");
int difficulty = int.Parse(Console.ReadLine().Trim());

if (difficulty == 1)
{
    Easy();
}
else if (difficulty == 2)
{
    Medium();
}
else if (difficulty == 3)
{
    Hard();
}
else if (difficulty == 4)
{
    Cheater();
}
else
{
    Console.WriteLine("Please Choose a number 1-4");
}

GuessingGame();
void GuessingGame()
{
    Console.WriteLine($"You have {guessesAllowed} guesses left!");
    while (NumberOfGuesses < guessesAllowed)
    {
        Console.WriteLine("Enter a number between 1 and 100");
        int guess = int.Parse(Console.ReadLine().Trim());
        NumberOfGuesses++;
        int guessesLeft = (guessesAllowed - NumberOfGuesses);

        if (guess == secretNumber)
        {
            Console.WriteLine("You guessed right!!");
            return;
        }
        else
        {
            if (guessesLeft == 0)
            {
                Console.WriteLine($"The secret number was {secretNumber}. Good luck next time!");
            }
            else 
            { 
                if (guess > secretNumber)
                {
                    Console.WriteLine($"Your guess is too high. You have {guessesLeft} guesses left!");
                }
                else
                {
                    Console.WriteLine($"Your guess is too low. You have {guessesLeft} guesses left!");
            }
            }
        }
    }
}
void Easy()
{
    guessesAllowed = 8;
}
void Medium()
{
    guessesAllowed = 6;
}
void Hard()
{
    guessesAllowed = 4;
}
void Cheater()
{
   int guess = 0;
    while (guess != secretNumber)
    {
        Console.WriteLine("Enter a number between 1 and 100");
        guess = int.Parse(Console.ReadLine().Trim());
        NumberOfGuesses++;

        if (guess == secretNumber)
        {
            Console.WriteLine("You guessed right!!");
            return;
        }
        else
        {
            if (guess > secretNumber)
            {
                Console.WriteLine($"Your guess is too high.");
            }
            else
            {
                Console.WriteLine($"Your guess is too low.");
            }
        }
    }
}