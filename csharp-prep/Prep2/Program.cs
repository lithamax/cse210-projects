using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();

        int grade = int.Parse(userInput);

        string letter = "";

        if (grade >= 70)
        {

            if (grade >= 90)
            {
                letter = "A";
            }  
            else if (grade >= 80)
            {
                letter = "B";
            }
            else if (grade >= 70)
            {
                letter = "C";
            }
        Console.WriteLine($"Your grade is {letter}.");         
        Console.WriteLine("Congratulations and well done, you have passed!");
        }
        else if (grade <70)
        {
            if (grade >= 60)
            {
                letter = "D";
            }
            else
            {
                letter = "F";
            }
        Console.WriteLine($"Your grade is {letter}.");
        Console.WriteLine("Sorry, you failed the course. Try again next time!");
        }
        
    }
}