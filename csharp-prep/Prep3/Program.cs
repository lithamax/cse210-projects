using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.Write("What is the magic number? ");
        //int userNumber = int.Parse(Console.ReadLine());
        Random randomGenerator = new Random();
        int userNumber = randomGenerator.Next(1, 101);
        
        int userGuess = -1;

        while (userGuess != userNumber)
        {
            Console.Write("What is your guess? ");
            userGuess = int.Parse(Console.ReadLine());

            if (userGuess > userNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (userGuess < userNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
            Console.WriteLine("You guessed it!");
            }            
        
        }
        

    }
}