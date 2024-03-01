using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int userPercent = int.Parse(userInput);

        if (userPercent == 70 || userPercent > 70)
        {
            Console.Write("Congratulations, you passed!");
        }
        else
        {
            Console.Write("You failed. Try again next time!");
        }

            if (userPercent == 90 || userPercent > 90)
            {
                Console.Write("You achieved an A symbol");
            }
            else if (userPercent == 80 || userPercent > 80)
            {
                Console.Write("You achieved a B symbol");
            }
            else if (userPercent == 70 || userPercent > 70)
            {
                Console.Write("You achieved a C symbol");
            }
            else if (userPercent == 60 || userPercent > 60)
            {
                Console.Write("You achieved a D symbol");
            }
            else 
            {
                Console.Write("Unfortunately you obtained an F symbol");
            }
        
        
        
    }
}