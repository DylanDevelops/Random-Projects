using System;

class Program
{
    static void Main(string[] args)
    {
        /*
        
        // Password Username Enter

        Console.WriteLine("Enter Username:");
        string username = Console.ReadLine();

        Console.WriteLine("\nEnter Password:");
        string password = Console.ReadLine();
        
        int passwordLength = password.Length;

        if(passwordLength < 10)
        {
            Console.WriteLine("\nThat password is way to easy to crack. \nTry Again. \n");
            
        }
        Console.WriteLine($"Username: {username} \nPassword: {password}");

        */

        /*

        // Calculator
        Console.WriteLine("Enter a whole number:");
        int numberOne = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"\nEnter a number to be multiplied by {numberOne}.");
        int numberTwo = Convert.ToInt32(Console.ReadLine());

        int answer = numberOne * numberTwo;

        Console.WriteLine($"\nAnswer: {numberOne} X {numberTwo} = {answer}");

        */

        

        // Guess Number

        int theNumber = 8;
        int minimum = 1;
        int maximum = 10;

        Console.WriteLine("Guess a number between 1 and 10:");
        
        int guess = Convert.ToInt32(Console.ReadLine());
        
        while(guess <= theNumber - 1 || guess >= theNumber + 1)
        {
            Console.WriteLine("\nGuess Again:");
            guess = Convert.ToInt32(Console.ReadLine());

            if(guess < minimum)
            {
                Console.WriteLine($"\n{guess} is below 1! Guess again:");
                guess = Convert.ToInt32(Console.ReadLine());
            }
            
            if(guess > maximum)
            {
                Console.WriteLine($"\n{guess} is above 10! Guess again:");
                guess = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine($"\nYou got it! The number was {theNumber}! You had to have been cheating. This was bulletproof!");
    }
}