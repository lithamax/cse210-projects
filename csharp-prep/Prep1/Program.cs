using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your name? ");
        string firstName = Console.ReadLine();

        Console.Write("What is your surname? ");
        string lastName = Console.ReadLine();

        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}