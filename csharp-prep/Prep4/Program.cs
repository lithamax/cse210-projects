using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
                        
            int userNumber = -1;
            while (userNumber != 0)
            {
                Console.Write("Please enter a number (type 0 to quit): ");
                
                string userInput = Console.ReadLine();
                userNumber = int.Parse(userInput);
                                
                if (userNumber != 0)
                {
                    numbers.Add(userNumber);
                }
            }
            
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }

            Console.WriteLine($"The sum is: {sum}");

            
            float average = ((float)sum) / numbers.Count;
            Console.WriteLine($"The average is: {average}");
                        
            int maximum = numbers[0];

            foreach (int number in numbers)
            {
                if (number > maximum)
                {
                    
                    maximum = number;
                }
            }

            Console.WriteLine($"The max is: {maximum}");
    }
}