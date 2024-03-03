using System;

class Program
{
    static void Main(string[] args)
    {
    
        //Random randomGenerator = new Random();
        //int userNumber = randomGenerator.Next(1, 101);
        Console.Write("What is the magic number? ");
        int magicNumber = int.Parse(Console.ReadLine());
        
        int userGuess = -1;

        while (userGuess != magicNumber)
        {
            Console.Write("What is your guess? ");
            userGuess = int.Parse(Console.ReadLine());

            if (userGuess < magicNumber)
            {
                Console.WriteLine("Guess higher");
            }
            else if (userGuess > magicNumber)
            {
                Console.WriteLine("Guess lower");
            }
            else
            {
                Console.Write("You guessed it!");
            }
        }
        
        


    }
}