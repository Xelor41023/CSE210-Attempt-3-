using System;

class Program
{
    static void Main(string[] args)
    {
        int hiddenNumber = 0;
        int userGuess = 0;
        int guessCounter = 0;
        bool gameOver = false;
        bool validInput = false;
        string userInput = "";
        bool correctGuess = false;

        do
        {
            Console.WriteLine("I am thinking of a whole integer from 1-100 can you guess it ?");
            Random randomGenerator = new Random();
            int randomNumber = randomGenerator.Next(1,100);
            hiddenNumber = randomNumber;

            do
            {
                try
                {
                    userGuess = int.Parse(Console.ReadLine());

                    if (userGuess > hiddenNumber)
                    {
                        Console.WriteLine("Guess A Lower Number");
                        guessCounter++;
                    }
                    else if (userGuess < hiddenNumber)
                    {
                        Console.WriteLine("Guess A Higher Number");
                        guessCounter++;
                    }
                    else if (userGuess == hiddenNumber)
                    {
                        correctGuess = true;
                        Console.WriteLine(@$"Correct! the hidden number was {hiddenNumber} You Guessed it in {guessCounter} Guesses");
                        Console.WriteLine("Play Again? Enter Y or N");
                    }
                }

                catch (System.Exception)
                {
                    Console.WriteLine("Invalid input enetered  on line 24 of program.cs");
                }
                

            }while (correctGuess == false);


            do{

                try
                {
                    userInput = Console.ReadLine().ToLower();
                    validInput = true;
                }
                catch{
                    Console.WriteLine("Invalid input entered on line 55 of program.cs ");
                }
            }while (validInput == false);

            if (userInput == "y")
            {
                gameOver = false;
            }

            else if (userInput == "n")
            {
                Console.WriteLine("Exiting Program");
                gameOver = true;
            }
           
        }while(gameOver == false);

    }
}